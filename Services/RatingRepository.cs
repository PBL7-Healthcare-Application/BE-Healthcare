using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public class RatingRepository : IRatingRepository
    {
        private readonly MyDbContext _context;
        private readonly IAppointmentRepository _appointmentRepository;

        public RatingRepository(MyDbContext context, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            _appointmentRepository = appointmentRepository;
        }

        private void AddRating(Guid IdUser, RatingModel model)
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
                _context.Appointments.Update(appointment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public ApiResponse CreateRating(Guid IdUser, RatingModel model)
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
    }
}
