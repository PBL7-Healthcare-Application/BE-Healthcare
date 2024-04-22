﻿using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.Authentication.Login;
using BE_Healthcare.Models.Authentication.SignUp;

namespace BE_Healthcare.Services
{
    public interface IUserRepository
    {
        ApiResponse Validate(LoginModel model);

        TokenModel GenerateToken(User user);
        ApiResponse RenewToken(TokenModel model);

        User getUserByEmail(string email);

        ApiResponse SignUp(SignUpModel model);
        void CreateUser(SignUpModel user, string token);
    }
}
