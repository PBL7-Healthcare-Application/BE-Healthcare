using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace BE_Healthcare.Services
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MyDbContext _context;

        public DoctorRepository(MyDbContext context)
        {
            _context = context;
        }

        public ApiResponse GetAllDoctor(string search, int? exp, double? from, double? to, string sortBy, int? id_specialty)
        {
            try
            {
                var listDoctor = _context.Doctors.AsQueryable();

                #region Filtering
                if (id_specialty.HasValue)
                {
                    listDoctor = listDoctor.Where(d => d.Id_Specialty == id_specialty);
                }
                if (!string.IsNullOrEmpty(search))
                {
                    listDoctor = listDoctor.Where(d => d.User.Name.Contains(search));
                }
                if (exp.HasValue)
                {
                    listDoctor = listDoctor.Where(d => d.YearExperience == exp);
                }
                if (from.HasValue)
                {
                    listDoctor = listDoctor.Where(d => d.Price >= from);
                }
                if (to.HasValue)
                {
                    listDoctor = listDoctor.Where(d => d.Price <= to);

                }
                #endregion


                #region Sorting

                if (!string.IsNullOrEmpty(sortBy))
                {
                    switch (sortBy)
                    {

                        case "exp_asc": listDoctor = listDoctor.OrderBy(d => d.YearExperience); break;  //YearExperience tang dan
                        case "exp_desc": listDoctor = listDoctor.OrderBy(d => d.YearExperience); break; //YearExperience giam dan
                        case "gia_asc": listDoctor = listDoctor.OrderBy(d => d.Price); break;
                        case "gia_desc": listDoctor = listDoctor.OrderByDescending(d => d.Price); break;
                    }
                }
                #endregion

                var result = listDoctor.Select(d => new DoctorModel
                {
                    Id_Doctor = d.Id_Doctor,
                    Name = d.User.Name,
                    MedicalSpecialty = d.MedicalSpecialty.Name,
                    Price = d.Price,
                    Address = d.User.Address,
                    YearExperience = d.YearExperience
                });

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = result
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
