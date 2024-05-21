using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
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


        public PartnerRepository(MyDbContext context, ICertificateRepository certificateRepository, 
            IWorkingProcessRepository workingProcessRepository, ITrainingProcessRepository trainingProcessRepository,
            IDoctorRepository doctorRepository)
        {
            _context = context;
            _certificateRepository = certificateRepository;
            _workingProcessRepository = workingProcessRepository;
            _trainingProcessRepository = trainingProcessRepository;
            _doctorRepository = doctorRepository;


        }

        public ApiResponse RegisterAsDoctor(Guid idUser, RegistrationFormDoctorModel model)
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
                    //YearExperience = model.YearExperience,
                    //Price = model.Price,
                    //Description = model.Description,
                    IdSpecialty = model.IdSpecialty,
                    IdUser = idUser,
                    StatusVerified = AppNumber.PENDING,
                    BusinessLicense = model.BusinessLicense,
                    NameClinic = model.NameClinic,
                };

                if(model.Certificates != null)
                {
                    newDoctor.IsVerifiedAllInfo = false;
                    _certificateRepository.AddListCertificate(newDoctor.IdDoctor, model.Certificates);
                }
                if(model.WorkingProcesses != null)
                {
                    newDoctor.IsVerifiedAllInfo = false;
                    _workingProcessRepository.AddListWorkingProcess(newDoctor.IdDoctor, model.WorkingProcesses);
                }
                if(model.TrainingProcesses != null)
                {
                    newDoctor.IsVerifiedAllInfo = false;
                    _trainingProcessRepository.AddListTrainingProcess(newDoctor.IdDoctor, model.TrainingProcesses);
                }

                _doctorRepository.AddDoctor(newDoctor);

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
            return _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).AsQueryable().Where(e => e.StatusVerified == 0);
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

        public ApiResponse VerifyInfoPartner(VerifyPartnerModel model)
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
                _context.Doctors.Update(partner);
                _context.SaveChanges();

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
    }
}
