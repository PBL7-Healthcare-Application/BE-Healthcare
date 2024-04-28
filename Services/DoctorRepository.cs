using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BE_Healthcare.Services
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MyDbContext _context;

        public DoctorRepository(MyDbContext context)
        {
            _context = context;
        }

        public ApiResponse GetAllDoctor(string? search = null, int? exp = null, double? from = null, double? to = null, string? sortBy = null, int? id_specialty = null)
        {
            try
            {
                var listDoctor = _context.Doctors.AsQueryable();

                #region Filtering
                if (id_specialty.HasValue)
                {
                    listDoctor = listDoctor.Where(d => d.IdSpecialty == id_specialty);
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
                    IdDoctor = d.IdDoctor,
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
        public List<CertificateModel> GetCertificateByIdDoctor(Guid id)
        {
            var list_Certificate = _context.Certificates.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            var result_certificate = list_Certificate.Select(c => new CertificateModel
            {
                IdCertificate = c.IdCertificate,
                Name = c.Name,
                Year = c.Year,
                Image = c.Image
            }).ToList();
            return result_certificate;
        }
        public List<WorkingProcessModel> GetWorkingProcessByIdDoctor(Guid id)
        {
            var list_WorkingProcess = _context.WorkingProcesses.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            var result_WorkingProcess = list_WorkingProcess.Select(c => new WorkingProcessModel
            {
                IdWorkingProcess = c.IdWorkingProcess,
                Position = c.Position,
                StartYear = c.StartYear,
                EndYear = c.EndYear,
                Workplace = c.Workplace
            }).ToList();
            return result_WorkingProcess;
        }
        public List<TrainingProcessModel> GetTrainingProcessByIdDoctor(Guid id)
        {
            var list_trainingProcess = _context.TrainingProcesses.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            var result_trainingProcess = list_trainingProcess.Select(c => new TrainingProcessModel
            {
                IdTrainingProcess = c.IdTrainingProcess,
                SchoolName = c.SchoolName,
                StartYear = c.StartYear,
                EndYear = c.EndYear,
                Major = c.Major
            }).ToList();
            return result_trainingProcess;
        }
        public List<TimeOffModel> GetTimeOffByIdDoctor(Guid id)
        {
            var list_timeOff = _context.TimeOffs.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id);
            var result_timeOff = list_timeOff.Select(c => new TimeOffModel
            {
                IdTimeOff = c.IdTimeOff,
                Date = c.Date,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Status = c.Status,
                Reason = c.Reason
            }).ToList();
            return result_timeOff;
        }

        public ApiResponse GetDoctorById(Guid id)
        {
            var Doctor = _context.Doctors.Include(p =>p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == id);

            if (Doctor == null)
            {
                return new ApiResponse
                {
                    StatusCode = StatusCode.FAILED,
                    Message = AppString.MESSAGE_NOTFOUND_DOCTOR,
                };
            }
            var list_Certificate = GetCertificateByIdDoctor(id);

            var list_WorkingProcess = GetWorkingProcessByIdDoctor(id);

            var list_TrainingProcess = GetTrainingProcessByIdDoctor(id);

            var list_TimeOff = GetTimeOffByIdDoctor(id);


            DoctorDetailModel result = new DoctorDetailModel    
            {
                IdDoctor = Doctor.IdDoctor,
                Name = Doctor.User.Name,
                MedicalSpecialty = Doctor.MedicalSpecialty.Name,
                Price = Doctor.Price,
                Address = Doctor.User.Address,
                YearExperience = Doctor.YearExperience,
                PhoneNumber = Doctor.User.PhoneNumber,
                Certificates = list_Certificate,            //List information
                WorkingProcess = list_WorkingProcess,
                TrainingProcess = list_TrainingProcess,
                WorkingTimeStart = Doctor.WorkingTimeStart,
                WorkingTimeEnd = Doctor.WorkingTimeEnd,
                DurationPerAppointment = Doctor.DurationPerAppointment,
                TimeOffs = list_TimeOff,

            };



            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_GETDATA_SUCCESS,
                Data = result
            };
            //return result;
        }


    }
}
