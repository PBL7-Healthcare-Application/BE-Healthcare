using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDbContext _context;
        private readonly IAuthRepository _authRepository;

        public UserRepository(MyDbContext context, IAuthRepository authRepository)
        {
            _context = context;
            _authRepository = authRepository;

        }
        public IQueryable<User> GetAll()
        {
            return _context.Users.Include(p => p.Doctor).Include(q => q.Role).AsQueryable().Where(p => p.IsVerified == true &&
            p.idRole != AppNumber.ROLE_ADMIN);
        }
        private IQueryable<User> FilteringListUser(IQueryable<User> list, UserSearchCriteriaModel criteria)
        {
            if (criteria != null)
            {
                if (criteria.search != null)
                {
                    list = list.Where(d => d.Email.Contains(criteria.search));
                }
                if (criteria.role != null)
                {
                    list = list.Where(d => d.idRole == criteria.role);
                }
                if (criteria.status != null)
                {
                    list = list.Where(d => d.IsLocked == criteria.status);
                }
            }
            return list;
        }

        public ApiResponse GetAllUser(UserSearchCriteriaModel criteria)
        {
            try
            {
                var listUser = GetAll();
                listUser = FilteringListUser(listUser, criteria);
                int TotalItems = listUser.Count();

                var res = listUser.Skip((criteria.page - 1) * AppNumber.PAGE_SIZE).Take(AppNumber.PAGE_SIZE).ToList();
                var result = res.Select(p => new UserModel
                {
                    Email = p.Email,
                    CreatedDate = p.CreatedDate,
                    Role = p.Role.Name,
                    IsLocked = p.IsLocked,
                });

                return new ApiResponseWithPaging
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = result,
                    PagingInfo = new PagingInfoModel
                    {
                        TotalItems = TotalItems,
                        CurrentPage = criteria.page,
                        ItemsPerPage = AppNumber.PAGE_SIZE
                    }
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

        private ApiResponse? CheckifTheAccountDisabled(User? user)
        {
            if (user == null)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_USER,
                };
            }

            if (user.IsAdminDisabled)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_ERROR_ACCOUNTDISABLED,
                };
            }
            if (user.IsLocked)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_ERROR_CANNOTDISABLEACCOUNT_USERHADDISABLED,
                };
            }
            return null;
        }

        public ApiResponse DisableAccount(DisableAccountModel model)
        {
            try
            {
                var user = _authRepository.getUserByEmail(model.Email);

                var check = CheckifTheAccountDisabled(user);
                if(check != null) 
                {
                    return check;
                }

                user.IsLocked = true;
                user.IsAdminDisabled = true;

                _context.Update(user);
                _context.SaveChanges();
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_DISABLEACCOUNT_SUCCESS,
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
