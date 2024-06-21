using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using BE_Healthcare.Models.EmailModel;
using BE_Healthcare.Models.Partner;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Services
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly MyDbContext _context;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IWorkingProcessRepository _workingProcessRepository;
        private readonly ITrainingProcessRepository _trainingProcessRepository;
        private readonly IDoctorRepository _doctorRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IAuthRepository _authRepository;
        private readonly IEmailService _emailService;

        public PartnerRepository(MyDbContext context, ICertificateRepository certificateRepository, 
            IWorkingProcessRepository workingProcessRepository, ITrainingProcessRepository trainingProcessRepository,
            IDoctorRepository doctorRepository, INotificationRepository notificationRepository, IAuthRepository authRepository, IEmailService emailService)
        {
            _context = context;
            _certificateRepository = certificateRepository;
            _workingProcessRepository = workingProcessRepository;
            _trainingProcessRepository = trainingProcessRepository;
            _doctorRepository = doctorRepository;
            _notificationRepository = notificationRepository;
            _authRepository = authRepository;
            _emailService = emailService;
        }

        public async Task<ApiResponse> RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model)
        {
            try
            {
                var checkIdUser = _doctorRepository.GetDoctorByIdUser(idUser);
                if (checkIdUser != null) 
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_ERROR_APPLYPARTNER,
                    };
                }
                var newDoctor = new Doctor
                {
                    IdDoctor = Guid.NewGuid(),
                    IdSpecialty = model.IdSpecialty,
                    IdUser = idUser,
                    StatusVerified = AppNumber.PENDING,
                    BusinessLicense = model.BusinessLicense,
                    NameClinic = model.NameClinic,
                };
                _doctorRepository.AddDoctor(newDoctor);

                if (model.Certificates != null)
                {
                    newDoctor.IsVerifiedInfoCertificate = false;
                    await _certificateRepository.AddListCertificate(newDoctor.IdDoctor, model.Certificates);
                }
                if(model.WorkingProcesses != null)
                {
                    newDoctor.IsVerifiedInfoWorkingProcess = false;
                    _workingProcessRepository.AddListWorkingProcess(newDoctor.IdDoctor, model.WorkingProcesses);
                }
                if(model.TrainingProcesses != null)
                {
                    newDoctor.IsVerifiedInfoTrainingProcess = false;
                    _trainingProcessRepository.AddListTrainingProcess(newDoctor.IdDoctor, model.TrainingProcesses);
                }

                _context.Doctors.Update(newDoctor);
                _context.SaveChanges();

                //Create Notification for creating new appointment
                //await CreateNotification(model);
                var idAdmin = _authRepository.GetIdAdmin();
                if(idAdmin != null)
                    await _notificationRepository.CreateNotificationForRegisteringDoctor((Guid)idAdmin, newDoctor.IdDoctor, newDoctor.User.Name );

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_REGISTERDOCTOR_SUCCESS
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

        private IQueryable<Doctor> GetAllPartner()
        {
            return _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).AsQueryable();
        }
        private IQueryable<Doctor> FilteringListPartner(IQueryable<Doctor> list, PartnerSearchCriteriaModel criteria)
        {
            if (criteria.idSpecialty != null)
            {
                list = list.Where(d => d.IdSpecialty == criteria.idSpecialty);
            }
            if (criteria.search != null)
            {
                list = list.Where(d => d.User.Name.Contains(criteria.search));
            }
            return list;
        }
        public ApiResponse GetPartner(PartnerSearchCriteriaModel criteria)
        {
            try
            {
                var listPartner = GetAllPartner();
                if (criteria.TypePartner == AppNumber.TYPEPARTNER_PARTNER_REGISTRATIONFORM)
                {
                    listPartner = listPartner.Where(e => e.StatusVerified == AppNumber.PENDING);
                }
                if (criteria.TypePartner == AppNumber.TYPEPARTNER_DOCTOR_INFORMATION_PENDING_APPROVAL)
                {
                    listPartner = listPartner.Where(d => d.StatusVerified == AppNumber.APPROVED && 
                    d.IsVerifiedInfoCertificate == false || d.IsVerifiedInfoWorkingProcess == false || 
                    d.IsVerifiedInfoTrainingProcess == false);
                }
                if (listPartner == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.SUCCESS,
                        Message = AppString.MESSAGE_LISTPARTNER_EMPTY
                    };
                }

                listPartner = FilteringListPartner(listPartner, criteria);

                var totalItems = listPartner.Count();
                #region Paging
                listPartner = listPartner.Skip((criteria.page - 1) * AppNumber.PAGE_SIZE).Take(AppNumber.PAGE_SIZE);
                #endregion

                listPartner = listPartner.OrderBy(d => d.CreatedAt);

                var result = listPartner.Select(d => new ListPartnerModel
                {
                    IdDoctor = d.IdDoctor,
                    Name = d.User.Name,
                    MedicalSpecialty = d.MedicalSpecialty.Name,
                    CreatedDate = d.CreatedAt,
                    StatusVerified = d.StatusVerified,
                }).ToList();

                return new ApiResponseWithPaging
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = result,
                    PagingInfo = new PagingInfoModel
                    {
                        TotalItems = totalItems,
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
        public ApiResponse GetPartnerDetail(Guid idDoctor)
        {
            try
            {
                var partner = _doctorRepository.GetDoctorById(idDoctor);
                if(partner == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_PARTNER,
                    };
                }

                var list_Certificate = _certificateRepository.GetCertificateByIdDoctor(idDoctor);

                var list_WorkingProcess = _workingProcessRepository.GetWorkingProcessByIdDoctor(idDoctor);

                var list_TrainingProcess = _trainingProcessRepository.GetTrainingProcessByIdDoctor(idDoctor);

                var result = new DoctorDetailModel
                {
                    IdDoctor = partner.IdDoctor,
                    Name = partner.User.Name,
                    MedicalSpecialty = partner.MedicalSpecialty.Name,
                    Price = partner.Price,
                    Address = partner.User.Address,
                    YearExperience = partner.YearExperience,
                    PhoneNumber = partner.User.PhoneNumber,
                    Certificates = list_Certificate,            //List information
                    WorkingProcess = list_WorkingProcess,
                    TrainingProcess = list_TrainingProcess,
                    WorkingTimeStart = partner.WorkingTimeStart,
                    WorkingTimeEnd = partner.WorkingTimeEnd,
                    DurationPerAppointment = partner.DurationPerAppointment,
                    Description = partner.Description,
                    Avatar = partner.User.Avatar,
                    NameClinic = partner.NameClinic,
                };


                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_REGISTERDOCTOR_SUCCESS,
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
        private void SendEmailApprovedApplication(string subject, Doctor doctor)
        {
            var message = new MessageHTMLForApprovedApplicationModel(
                subject,
                new string[] { doctor.User.Email! },
                doctor.User.Name,
                doctor.User.Email
                );

            _emailService.SendEmailHTML(AppNumber.TYPEMAILHTML_FOR_APPROVED_APPLICATION, null, null, message);
        }
        public async Task<ApiResponse> VerifyInfoPartner(VerifyPartnerModel model)
        {
            try
            {
                var partner = _doctorRepository.GetDoctorById(model.IdDoctor);
                if (partner == null)
                {
                    return new ApiResponse
                    {
                        StatusCode = StatusCode.FAILED,
                        Message = AppString.MESSAGE_NOTFOUND_PARTNER,
                    };
                }

                partner.StatusVerified = model.StatusVerified;
                partner.IsVerifiedAt = DateTime.Now;
                if (partner.StatusVerified == AppNumber.APPROVED)
                {
                    partner.User.idRole = AppNumber.ROLE_DOCTOR;

                    SendEmailApprovedApplication("Approved Application", partner);

                }
                _context.Doctors.Update(partner);
                _context.SaveChanges();
                
                //Create Notification
                await _notificationRepository.CreateNotificationForVerifyingDoctor((int)model.StatusVerified, model.IdDoctor);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_VERIFYINFPARTNER_SUCCESS,
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

        public async Task<ApiResponse> VerifyCertificate(VerifyCertificateModel model)
        {
            try
            {
                _certificateRepository.VerifyCertificate(model);
                await _notificationRepository.CreateNotificationForVerifyingDoctor(0, model.IdDoctor, true);

                //Check if there are any cetificate that have not been verified
                _doctorRepository.UpdateFieldIsVerifiedInfoCertificate(model.IdDoctor);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_VERIFYCERTIFICATE_SUCCESS,
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
        public async Task<ApiResponse> VerifyWorkingProcess(VerifyWorkingProcessModel model)
        {
            try
            {
                _workingProcessRepository.VerifyWorkingProcess(model);
                await _notificationRepository.CreateNotificationForVerifyingDoctor(0, model.IdDoctor, true);


                //Check if there are any workingprocesses that have not been verified
                _doctorRepository.UpdateFieldIsVerifiedInfoWorkingProcess(model.IdDoctor);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_VERIFYWORKINGPROCESS_SUCCESS,
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
        public async Task<ApiResponse> VerifyTrainingProcess(VerifyTrainingProcessModel model)
        {
            try
            {
                _trainingProcessRepository.VerifyTrainingProcess(model);
                await _notificationRepository.CreateNotificationForVerifyingDoctor(0, model.IdDoctor, true);

                //Check if there are any working processes that have not been verified
                _doctorRepository.UpdateFieldIsVerifiedInfoTrainingProcess(model.IdDoctor);

                return new ApiResponse
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_VERIFYTRAININGPROCESS_SUCCESS,
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
