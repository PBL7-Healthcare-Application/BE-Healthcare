using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.MedicalRecord;

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
    }
}
