using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public class MedicalSpecialtyRepository : IMedicalSpecialtyRepository
    {
        private readonly MyDbContext _context;

        public MedicalSpecialtyRepository(MyDbContext context)
        {
            _context = context;
        }

        public ApiResponse GetAllMedicalSpecialty()
        {
            try
            {
                var list = _context.MedicalSpecialties.AsQueryable().OrderBy(e => e.Name);

                //var result = listDoctor.Select(d => new DoctorModel
                //{
                //    Id_Doctor = d.Id_Doctor,
                //    Name = d.User.Name,
                //    MedicalSpecialty = d.MedicalSpecialty.Name,
                //    Price = d.Price,
                //    Address = d.User.Address,
                //    YearExperience = d.YearExperience
                //});

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = list
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
