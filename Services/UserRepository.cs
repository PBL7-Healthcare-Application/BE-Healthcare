﻿using BE_Healthcare.Models;
using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.Net;
using BE_Healthcare.Models.Authentication.Login;
using BE_Healthcare.Models.Authentication.SignUp;
using BE_Healthcare.Models.EmailModel;
using Org.BouncyCastle.Crypto;

namespace BE_Healthcare.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDbContext _context;
        private readonly AppSetting _appSetting;
        private readonly IEmailService _emailService;
        public UserRepository(MyDbContext context, IOptionsMonitor<AppSetting> optionsMonitor, IEmailService emailService)
        {
            _context = context;
            _appSetting = optionsMonitor.CurrentValue;
            _emailService = emailService;
        }
        public ApiResponse Validate(LoginModel model)
        {
            try
            {
                if (!Extension.ValidEmail(model.Email))     //Validate Email
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_INCORRECT_EMAIL,
                    };
                }
                if (!Extension.IsValidPassword(model.Password)) //Validate Password
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_INVALID_PASSWORD,
                    };
                }

                var currentUser = getUserByEmail(model.Email);
                if (currentUser == null) //Not Found User
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }
                if ((bool)!currentUser.IsVerified)
                {
                    if ((bool)!currentUser.IsVerified)
                    {
                        //xoa record trong DB
                        DeleteUserByEmail(currentUser.Email);
                    }

                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_USER,
                    };
                }


                if (!CheckPassword(currentUser, model.Password))   //Check Password
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_PASSWORD_NOT_MATCH,
                    };
                }
                //Cap Token
                var token = GenerateToken(currentUser);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_AUTH_SUCCESS,
                    Data = token
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }

        public TokenModel GenerateToken(User user)
        {
            try
            {
                var jwtTokenHandler = new JwtSecurityTokenHandler();

                var secretKeyBytes = Encoding.UTF8.GetBytes(_appSetting.SecretKey);

                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim("Id_User", user.Id_User.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),

                }),
                    Expires = DateTime.UtcNow.AddSeconds(60),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey
                    (secretKeyBytes), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = jwtTokenHandler.CreateToken(tokenDescription);
                var accessToken = jwtTokenHandler.WriteToken(token);
                var refreshToken = GenerateRefreshToken();
                //var refreshToken = "refreshtoken";


                var refreshTokenEntity = new RefreshToken
                {
                    Id = Guid.NewGuid(),
                    JwtId = token.Id,
                    UserId = user.Id_User,
                    Token = refreshToken,
                    IsUsed = false,
                    IsRevoked = false,
                    IssuedAt = DateTime.UtcNow,
                    ExpiredAt = DateTime.UtcNow.AddHours(1)
                };

                _context.Add(refreshTokenEntity);
                _context.SaveChanges();

                return new TokenModel
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new TokenModel
                {
                    AccessToken = null,
                    RefreshToken = null,
                };
            }
        }
        private string GenerateRefreshToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
            }
            return Convert.ToBase64String(random);
        }

        public ApiResponse RenewToken(TokenModel model)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var secretKeyBytes = Encoding.UTF8.GetBytes(_appSetting.SecretKey);

            var tokenValidateParam = new TokenValidationParameters
            {

                //tu cap token
                ValidateIssuer = false,
                ValidateAudience = false,

                //ky vao token
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

                ClockSkew = TimeSpan.Zero,

                ValidateLifetime = false //ko kiem tra token het han
            };

            try
            {
                //Check 1: AccessToken valid Format
                var tokenInVerification = jwtTokenHandler.ValidateToken(model.AccessToken,
                    tokenValidateParam, out var validatedToken);

                //Check 2: Check Alg
                if (validatedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                        StringComparison.InvariantCultureIgnoreCase);
                    if (!result) //false
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_INVALID_TOKEN
                        };
                    }
                }

                //Check 3: Check accessToken expire?
                var expClaim = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp);
                if (expClaim != null && long.TryParse(expClaim.Value, out long utcExpireDate))
                {
                    var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
                    if (expireDate > DateTime.UtcNow)
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_ACCESSTOKEN_NOT_EXPIRED
                        };
                    }
                }

                //Check 4: Check refreshToken exist in DB?
                var storedToken = _context.RefreshTokens.FirstOrDefault(x => x.Token == model.RefreshToken);
                if (storedToken == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_REFRESHTOKEN_NOT_EXIST
                    };
                }

                //Check 5: check refreshToken is used/revoked?
                if (storedToken.IsUsed)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_REFRESHTOKEN_USED
                    };
                }

                if (storedToken.IsRevoked)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_REFRESHTOKEN_REVOKED
                    };
                }

                //Check 6: AccessToken id == JwtId in RefreshToken
                var jtiClaim = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti);
                string? jti = jtiClaim?.Value;
                if (storedToken.JwtId != jti)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ACCESSTOKEN_NOT_MATCHED
                    };
                }

                //Update token is used
                storedToken.IsRevoked = true;
                storedToken.IsUsed = true;
                _context.Update(storedToken);
                _context.SaveChanges();

                //Create new token
                var user = _context.Users.FirstOrDefault(x => x.Id_User == storedToken.UserId);
                var token = GenerateToken(user);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_RENEW_TOKEN_SUCCESS,
                    Data = token
                };



            }
            catch
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR
                };
            }
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();

            return dateTimeInterval;
        }

        public User getUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(x => x.Email == email);
        }
        public void DeleteUserByEmail(string email)
        {
            _context.Users.Remove(getUserByEmail(email));
            _context.SaveChanges();
        }

        public bool CheckPassword(User currentUser, string password)
        {
            using var hashFunc = new HMACSHA256(currentUser.PasswordSalt);
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var passwordHash = hashFunc.ComputeHash(passwordBytes);
            for (int i = 0; i < passwordHash.Length; i++)
            {
                if (passwordHash[i] != currentUser.PasswordHash[i])
                    return false;
            }
            return true;
        }

        public ApiResponse SignUp(SignUpModel model)
        {
            try
            {
                if (!Extension.ValidEmail(model.Email))     //Validate Email
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_INCORRECT_EMAIL,
                    };
                }
                if (!Extension.IsValidPassword(model.Password)) //Validate Password
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_INVALID_PASSWORD,
                    };
                }

                if (getUserByEmail(model.Email) is not null)    //Check email exist in the system
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_EMAIL_EXIST,
                    };
                }

                var token = GenerateOTP();  // Generate and send OTP to the user's email

                CreateUser(model, token);

                SendOTPToEmail(model.Email, token);


                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_OTP_SENT_SUCCESSFUL,
                    Data = new MailModel { email =  model.Email}
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }
        private void SendOTPToEmail(string email, string token)
        {
            var message = new MessageModel(new string[] { email! }, AppString.MESSAGE_EMAIL_SUBJECT, token + AppString.MESSAGE_EMAIL_CONTENT);
            _emailService.SendEmail(message);
        }

        public void CreateUser(SignUpModel user, string token)
        {
            try
            {
                using var hashFunc = new HMACSHA256();
                var passwordBytes = Encoding.UTF8.GetBytes(user.Password);

                var _user = new User
                {
                    Id_User = Guid.NewGuid(),
                    Email = user.Email,
                    PasswordHash = hashFunc.ComputeHash(passwordBytes),
                    PasswordSalt = hashFunc.Key,
                    Name = user.Name,
                    PhoneNumber = user.PhoneNumber,
                    OTPVerification = token,
                    OTPCreatedAt= GenerateTimeNowAtVN(),
                    IsVerified = false,
                    id_Role = 1,

                };
                _context.Users.Add(_user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private string GenerateOTP()    // Method to generate OTP
        {
            int otpLength = 6;

            Random random = new Random();
            string otp = "";
            for (int i = 0; i < otpLength; i++)
            {
                otp += random.Next(0, 9).ToString();
            }

            return otp;
        }

        private DateTime GenerateTimeNowAtVN() 
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.Local);
        }
        public ApiResponse ConfirmEmail(ConfirmMailModel model)
        {
            try
            {
                var currentUser = getUserByEmail(model.email);
                if (currentUser != null)
                {
                    if (model.otp != currentUser.OTPVerification) //OTP Code doesn't match
                    {
                        return new ApiResponse
                        {
                            StatusCode = StatusCode.FAILED,
                            Message = AppString.MESSAGE_OTP_NOTMATCH,
                        };

                    }

                    
                    if (currentUser.OTPCreatedAt.HasValue)  // Check if OTP creation time is not null
                    {
                        var otpExpiryTime = currentUser.OTPCreatedAt.Value.AddMinutes(2);

                        if (otpExpiryTime < GenerateTimeNowAtVN())  // Check if the OTP code is expired
                        {
                            return new ApiResponse
                            {
                                StatusCode = StatusCode.FAILED,
                                Message = AppString.MESSAGE_OTP_EXPIRED,
                            };
                        }
                    }
                    else
                    {

                        return new ApiResponse  // Handle case where OTP creation time is null (optional)
                        {
                            StatusCode = StatusCode.FAILED,
                            Message =AppString.MESSAGE_OTP_CREATIONTIME_NULL,
                        };
                    }

                    //Success -> Update Field 
                    currentUser.IsVerified = true;
                    _context.SaveChanges();

                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_EMAIL_VERIFIED,
                    };
                }
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_USER,
                };
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }
        public ApiResponse ResendOTP(string email)
        {
            try
            {
                var currentUser = getUserByEmail(email);
                if (currentUser != null)
                {
                    //Success -> Update Field 
                    currentUser.OTPVerification = GenerateOTP();
                    currentUser.OTPCreatedAt = GenerateTimeNowAtVN();
                    _context.SaveChanges();
                    SendOTPToEmail(email, currentUser.OTPVerification);

                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_OTP_RESEND,
                        Data = new MailModel{ email = email }
                    };
                }
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_USER,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_SERVER_ERROR,
                };
            }
        }

    }
}
