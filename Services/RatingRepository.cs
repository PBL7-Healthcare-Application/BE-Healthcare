using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BE_Healthcare.Services
{
    public class RatingRepository : IRatingRepository
    {
        private readonly MyDbContext _context;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IDoctorRepository _doctorRepository;

        public RatingRepository(MyDbContext context, IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository)
        {
            _context = context;
            _appointmentRepository = appointmentRepository;
            _doctorRepository = doctorRepository;
        }
        private IQueryable<Rating> GetListRatingByIdDoctor(Guid idDoctor)
        {
            return _context.Ratings.Include(p => p.User).Include(q => q.Doctor).Where(e => e.IdDoctor == idDoctor);
        }
        private void AddRating(Guid IdUser, CreateRatingModel model)
        {
            try
            {
                var rating = new Rating
                {
                    RatingScore = model.RatingScore,
                    Comment = model.Comment,
                    IdUser = IdUser,
                    IdDoctor = model.IdDoctor,
                    IdAppointment = model.IdAppointment
                };

                _context.Ratings.Add(rating);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void UpdateAppointmentIsRated(Appointment appointment)
        {
            try
            {
                appointment.IsRating = true;
                _appointmentRepository.UpdateAppointment(appointment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void UpdateRatingScoreOfDoctor(Guid idDoctor, int ratingScore)
        {
            try
            {
                var doctor = _doctorRepository.GetDoctorById(idDoctor);
                if(doctor != null)
                {
                    doctor.NumberOfComment++;
                    var numberOfRating = GetListRatingByIdDoctor(idDoctor).Count();
                    if (numberOfRating == 1)
                    {
                        doctor.RateAverage = ratingScore;
                    }
                    else if (numberOfRating > 1)
                    {
                        doctor.RateAverage = (doctor.RateAverage * (numberOfRating - 1) + ratingScore) / numberOfRating;
                    }
                    _context.Doctors.Update(doctor);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public ApiResponse CreateRating(Guid IdUser, CreateRatingModel model)
        {
            try
            {
                var appointment = _appointmentRepository.GetAppointmentByIdAppointment(model.IdAppointment);
                if (appointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_APPOINTMENT,
                    };
                }
                if(appointment.IsRating)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_APPOINTMENT_ISEVALUATED,
                    };
                }

                //Add new Rating
                AddRating(IdUser, model);

                //Update Appointment is Rated
                UpdateAppointmentIsRated(appointment);

                //Update Rating Score and Comment of Doctor
                if(appointment.IdDoctor != null)
                {
                    UpdateRatingScoreOfDoctor((Guid)appointment.IdDoctor, model.RatingScore);
                }

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_EVALUATED_SUCCESS,
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

        public ApiResponse GetRatingByIdDoctor(GetRatingCriteriaModel model)
        {
            try
            {
                var listRating = GetListRatingByIdDoctor(model.IdDoctor);
                if (listRating == null)
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_LISTRATING_EMPTY,
                    };
                listRating = listRating.OrderByDescending(p => p.CreatedAt);
                int TotalItems = listRating.Count();

                var result = listRating.Select(c => new ListRatingModel
                {
                    IdRating = c.IdRating,
                    RatingScore = c.RatingScore,
                    Comment = c.Comment,
                    CreatedAt = c.CreatedAt,
                    NameUserRating = c.User.Name,
                    UrlAvatarUserRating = c.User.Avatar,
                }).ToList();

                var statisticalTable = GetTableOfRatings(model.IdDoctor);
                return new ApiResponseWithPagingAndTableRating
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = result,
                    PagingInfo = new PagingInfoModel
                    {
                        TotalItems = TotalItems,
                        CurrentPage = model.page,
                        ItemsPerPage = AppNumber.PAGE_SIZE
                    },
                    StatisticalTableOfRating = statisticalTable
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
        
        private StatisticalTableOfRatingModel GetTableOfRatings(Guid idDoctor)
        {
            var statisticalTable = new StatisticalTableOfRatingModel();
            var listRating = GetListRatingByIdDoctor(idDoctor);
            if (listRating == null)
                return statisticalTable;
            foreach( var rating in listRating)
            {
                switch (rating.RatingScore) 
                {
                    case 1: statisticalTable.one++; break;
                    case 2: statisticalTable.two++; break;
                    case 3: statisticalTable.three++; break;
                    case 4: statisticalTable.four++; break;
                    case 5: statisticalTable.five++; break;
                    default: break;
                }
            }
            return statisticalTable;
        }
    }
}
