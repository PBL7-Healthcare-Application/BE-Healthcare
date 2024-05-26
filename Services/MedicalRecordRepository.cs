using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.MedicalRecord;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Services
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {
        private readonly MyDbContext _context;
        private readonly IAppointmentRepository _appointmentRepository;
        public MedicalRecordRepository(MyDbContext context, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            _appointmentRepository = appointmentRepository;
        }
        public void AddMedicalRecord(MedicalRecordModel model)
        {
            var medicalRecord = new MedicalRecord
            {
                IdUser = model.IdUser,
                IdDoctor = (Guid)model.IdDoctor,
                Height = model.Height,
                Weight = model.Weight,
                Temperature = model.Temperature,
                Content = model.Content,
                IdAppointment = model.IdAppointment
            };
            _context.MedicalRecords.Add(medicalRecord);
            _context.SaveChanges();
        }

        public ApiResponse CreateMedicalRecord(MedicalRecordModel model)
        {
            try
            {
                var appointment = _appointmentRepository.GetAppointmentByIdAppointment(model.IdAppointment);
                if (appointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_APPOINTMENT
                    };
                }
                if(appointment.IdDoctor != model.IdDoctor)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_MEDICALRECORD_NOTALLOWTOCREATE
                    };
                }
                AddMedicalRecord(model);
    
                _appointmentRepository.UpdateAppointmentCompleted(model.IdAppointment);
                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_ADDMEDICALRECORD_SUCCESS
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

        public ApiResponse GetMedicalRecordByIdUser(Guid idUser)
        {
            try
            {

                var listMedicalRecord = _context.MedicalRecords.Include(e => e.User).Include(d => d.Doctor)
                    .AsQueryable().Where(e => e.IdUser == idUser);

                if (listMedicalRecord != null)
                {
                    var res = listMedicalRecord.Select(a => new MedicalRecordHistoryModel
                    {
                        IdDoctor = a.IdDoctor,
                        IdUser = a.IdUser,
                        IdAppointment = a.IdAppointment,
                        Height = a.Height,
                        Weight = a.Weight,
                        Temperature = a.Temperature,
                        Content = a.Content,
                        Date = a.Date,
                        Name = a.Doctor.User.Name,
                        MedicalSpecialty = a.Doctor.MedicalSpecialty.Name,
                    });
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_GETDATA_SUCCESS,
                        Data = res
                    };
                }
                else
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_LISTAPPOINTMENT_EMPTY,
                    };
                }
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

        public ApiResponse GetListExaminationByIdDoctor(Guid idDoctor, string? search = null)
        {
            try
            {
                _appointmentRepository.UpdateStatusAppointment(idDoctor);
                var listAppointment = _appointmentRepository.GetListAppointmentByIdDoctor(idDoctor, AppNumber.APPOINTMENT_CONFIRMED,
                    search);

                //Sorting
                if (listAppointment == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_LISTEXAMINATION_EMPTY,
                    };
                }

                var res = listAppointment.Select(a => new ExaminationModel
                {
                    IdUser = a.IdUser,
                    IdAppointment = a.IdAppointment,
                    StartTime = a.StartTime,
                    EndTime = a.EndTime,
                    Date = a.Date,
                    NamePatient = a.User.Name,
                    PhoneNumber = a.User.PhoneNumber,
                    Email = a.User.Email,
                    Status = a.Status,
                }).ToList();
                foreach( var item in res )
                {
                    string dateOnly = item.Date.ToString("M/d/yyyy");
                    string dateTimeString = $"{dateOnly} {item.StartTime}";
                    DateTime TimeStartAppointment = DateTime.ParseExact(dateTimeString, "M/d/yyyy H:mm", null);
                    item.StartTimeOfExamination = TimeStartAppointment;
                }

                res = res.OrderBy(e => e.StartTimeOfExamination).ToList();


                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = res
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
