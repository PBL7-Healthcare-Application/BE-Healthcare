using BE_Healthcare.Constant;
using BE_Healthcare.Data;
using BE_Healthcare.Data.Entities;
using BE_Healthcare.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;
using System.Numerics;
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
        public IQueryable<Doctor> GetAll()
        {
            return _context.Doctors.Include(p=>p.User).Include(q => q.MedicalSpecialty).AsQueryable();
        }
        public int GetTotalAppointmentByIdDoctor(DateTime d, Guid idDoctor)
        {
            int a= 0;
            if (d == DateTime.Now.Date)
            {
                DateTime now = DateTime.Now;
                TimeSpan timeNow = new TimeSpan(now.Hour, now.Minute, 0);
                //TimeSpan timeNow = TimeSpan.Parse("13:15");
                DateTime today = d.Date;
                var listAppointmentToday = _context.Appointments
                .Where( a => a.Date == today && a.IdDoctor == idDoctor).ToList();
                a = listAppointmentToday.Count();
                foreach(var appointment in listAppointmentToday)
                {
                    if( TimeSpan.Parse(appointment.StartTime) < timeNow)
                    {
                        a--;
                    }
                }
            }
            else
            {
                a = _context.Appointments
                .Count(a => a.Date == d.Date && a.IdDoctor == idDoctor);
            }
            return a;
        }

        private IQueryable<Doctor> FilteringListDoctor(IQueryable<Doctor> list, DoctorSearchCriteriaModel criteria)
        {
            if(criteria != null) 
            {
                if (criteria.idSpecialty != null)
                {
                    list = list.Where(d => d.IdSpecialty == criteria.idSpecialty);
                }
                if (criteria.search != null)
                {
                    list = list.Where(d => d.User.Name.Contains(criteria.search));
                }
                if (criteria.exp != null)
                {
                    list = list.Where(d => d.YearExperience == criteria.exp);
                }
                if (criteria.from != null)
                {
                    list = list.Where(d => d.Price >= criteria.from);
                }
                if (criteria.to != null)
                {
                    list = list.Where(d => d.Price <= criteria.to);
                }
            }
            return list;
        }

        //private List<Doctor> FindingAvailableDoctor()
        //{

        //}
        public ApiResponse GetAllDoctor(DoctorSearchCriteriaModel criteria)
        {
            try
            {
                var listDoctor = GetAll();

                #region Filtering
                //if (criteria.idSpecialty.HasValue)
                //{
                //    listDoctor = listDoctor.Where(d => d.IdSpecialty == criteria.idSpecialty);
                //}
                //if (!string.IsNullOrEmpty(criteria.search))
                //{
                //    listDoctor = listDoctor.Where(d => d.User.Name.Contains(criteria.search));
                //}
                //if (criteria.exp.HasValue)
                //{
                //    listDoctor = listDoctor.Where(d => d.YearExperience == criteria.exp);
                //}
                //if (criteria.from.HasValue)
                //{
                //    listDoctor = listDoctor.Where(d => d.Price >= criteria.from);
                //}
                //if (criteria.to.HasValue)
                //{
                //    listDoctor = listDoctor.Where(d => d.Price <= criteria.to);
                //}

                listDoctor = FilteringListDoctor(listDoctor, criteria);

                var availableDoctors = listDoctor.ToList();


                if (!string.IsNullOrEmpty(criteria.filterAvailable))
                {
                    DateTime t;
                    if(criteria.filterAvailable == "TODAY")
                    {
                        t = DateTime.Now.Date;
                        foreach (var doctor in listDoctor.ToList())
                        {
                            if(doctor.WorkingTimeStart != null && doctor.WorkingTimeEnd != null && doctor.DurationPerAppointment != null ) 
                            {
                                int availableTimeSlots = CalculateFreeSlots(doctor.IdDoctor, t, doctor.WorkingTimeStart, doctor.WorkingTimeEnd, (int)doctor.DurationPerAppointment);
                                if (availableTimeSlots <= 0)
                                {
                                    availableDoctors.Remove(doctor);
                                }
                            }

                        }

                    }
                    if (criteria.filterAvailable == "TOMORROW")
                    {
                        t = DateTime.Now.AddDays(1).Date;
                        foreach (var doctor in listDoctor.ToList())
                        {
                            if(doctor.WorkingTimeStart != null && doctor.WorkingTimeEnd != null && doctor.DurationPerAppointment != null )
                            {
                                int availableTimeSlots = CalculateFreeSlots(doctor.IdDoctor, t, doctor.WorkingTimeStart, doctor.WorkingTimeEnd, (int)doctor.DurationPerAppointment);
                                if (availableTimeSlots <= 0)
                                {
                                    availableDoctors.Remove(doctor);
                                }
                            }

                        }
                    }
                }
                #endregion


                #region Sorting

                if (!string.IsNullOrEmpty(criteria.sortBy))
                {
                    switch (criteria.sortBy)
                    {
                        case "exp_asc": availableDoctors = availableDoctors.OrderBy(d => d.YearExperience).ToList(); break;
                        case "exp_desc": availableDoctors = availableDoctors.OrderByDescending(d => d.YearExperience).ToList(); break;
                        case "gia_asc": availableDoctors = availableDoctors.OrderBy(d => d.Price).ToList(); break;
                        case "gia_desc": availableDoctors = availableDoctors.OrderByDescending(d => d.Price).ToList(); break;
                    }
                }
                #endregion

                #region Paging
                availableDoctors = availableDoctors.Skip((criteria.page - 1) * AppNumber.PAGE_SIZE).Take(AppNumber.PAGE_SIZE).ToList();
                #endregion

                var result = availableDoctors.Select(d => new DoctorModel
                {
                    IdDoctor = d.IdDoctor,
                    Name = d.User.Name,
                    MedicalSpecialty = d.MedicalSpecialty.Name,
                    Price = d.Price,
                    Address = d.User.Address,
                    YearExperience = d.YearExperience
                });

                return new ApiResponseWithPaging
                {
                    StatusCode = StatusCode.SUCCESS,
                    Message = AppString.MESSAGE_GETDATA_SUCCESS,
                    Data = result,
                    PagingInfo = new PagingInfoModel
                    {
                        TotalItems = availableDoctors.Count(),
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
        public List<TimeOffModel>? GetTimeOffByIdDoctor(Guid id)
        {
            var list_timeOff = _context.TimeOffs.Include(e => e.Doctor)
                .AsQueryable().Where(e => e.IdDoctor == id).ToList();
            if (list_timeOff == null) return null;
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
        public Doctor? GetDoctorById(Guid id)
        {
            var data = _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdDoctor == id);
            if (data != null)
                return data;
            return null;
        }

        public ApiResponse GetDoctorDetail(Guid id, List<SlotAppointmentModel>? list)
        {
            var Doctor = GetDoctorById(id);

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

            //var list_Appointment = GetTotalAppointmentByIdDoctor();

            var result = new DoctorDetailModel
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
                Description = Doctor.Description,
                Avatar = Doctor.User.Avatar,
                NameClinic = Doctor.NameClinic,
                //SlotAppointments
            };

            if (list != null)
            {
                result.SlotAppointments = list;
            }
            return new ApiResponse
            {
                StatusCode = StatusCode.SUCCESS,
                Message = AppString.MESSAGE_GETDATA_SUCCESS,
                Data = result
            };
            //return result;
        }


        public int CalculateFreeSlot(Guid idDoctor, DateTime d, string WorkingTimeStart, string WorkingTimeEnd, int DurationPerAppointment)
        {
            try
            {
                int availableTimeSlots;

                if (d == DateTime.Now.Date)
                {
                    DateTime now = DateTime.Now;
                    TimeSpan timeNow = new TimeSpan(now.Hour, now.Minute, 0); // Calculate how many hour left to do Today
                    //TimeSpan end = TimeSpan.Parse(WorkingTimeEnd);
                    TimeSpan end = TimeSpan.Parse("19:00");
                    TimeSpan total = end - timeNow;
                    int hour = (int)total.TotalHours;
                    int totalSlott = hour / DurationPerAppointment;

                    int appointments= GetTotalAppointmentByIdDoctor(d, idDoctor); // Calculate number of Appointment in remain hour Today

                }

                TimeSpan startTime = TimeSpan.Parse(WorkingTimeStart);
                TimeSpan endTime = TimeSpan.Parse(WorkingTimeEnd);
                TimeSpan totalHours = endTime - startTime;
                int totalSlot = (int)totalHours.TotalHours / DurationPerAppointment;

                //get appointment in a day 
                int appointmentsToday = GetTotalAppointmentByIdDoctor(d, idDoctor);

                availableTimeSlots = totalSlot - appointmentsToday;

                //get break time from time off 
                var TimeOffBreak = GetTimeOffByIdDoctor(idDoctor).Where(e => e.Status == AppNumber.BREAK).FirstOrDefault();
                if(TimeOffBreak != null)
                {
                    TimeSpan startTime_Break = TimeSpan.Parse(TimeOffBreak.StartTime);
                    TimeSpan endTime_Break = TimeSpan.Parse(TimeOffBreak.EndTime);
                    TimeSpan totalHours_Break = endTime_Break - startTime_Break;
                    int totalBreak = (int)totalHours_Break.TotalHours / DurationPerAppointment;
                    availableTimeSlots -= totalBreak;

                }

                //get busy time from time off
                var listTimeOffBusy = GetTimeOffByIdDoctor(idDoctor).Where(e => e.Status == AppNumber.BUSY && e.Date == d.Date);
                if (listTimeOffBusy != null)
                {
                    foreach(var i in listTimeOffBusy)
                    {
                        TimeSpan totalHours_Busy = TimeSpan.Parse(i.EndTime) - TimeSpan.Parse(i.StartTime);
                        int totalBusy= (int)totalHours_Busy.TotalHours / DurationPerAppointment;
                        availableTimeSlots -= totalBusy;
                    }

                }
                return availableTimeSlots > 0 ? availableTimeSlots : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }
        public int CalculateFreeSlots(Guid idDoctor, DateTime d, string WorkingTimeStart, string WorkingTimeEnd, int DurationPerAppointment)
        {
            try
            {
                int availableTimeSlots;

                if (d == DateTime.Now.Date)
                {

                    DateTime now = DateTime.Now;
                    TimeSpan timeNow = new TimeSpan(now.Hour, now.Minute, 0); // Calculate how many hour left to do Today
                    //TimeSpan timeNow = TimeSpan.Parse("13:15");
                    TimeSpan endTime = TimeSpan.Parse(WorkingTimeEnd);
                    //TimeSpan endTime = TimeSpan.Parse("17:00");

                    if (timeNow >= endTime) return 0;

                    TimeSpan totalHours = endTime - timeNow;
                    availableTimeSlots = (int)totalHours.TotalHours / DurationPerAppointment;

                }
                else
                {
                    TimeSpan startTime = TimeSpan.Parse(WorkingTimeStart);
                    TimeSpan endTime = TimeSpan.Parse(WorkingTimeEnd);
                    TimeSpan totalHours = endTime - startTime;
                    availableTimeSlots = (int)totalHours.TotalHours / DurationPerAppointment;

                }

                
                var listTimeOff = GetTimeOffByIdDoctor(idDoctor);
                if (listTimeOff != null)
                {
                    //get busy time from time off
                    var listTimeOffBusy = listTimeOff.Where(e => e.Status == AppNumber.BUSY && e.Date == d.Date).ToList();
                    if (listTimeOffBusy != null)
                    {
                        int TimeBusy = 0;
                        if (d == DateTime.Now.Date)
                        {
                            DateTime now = DateTime.Now;
                            TimeSpan timeNow = new TimeSpan(now.Hour, now.Minute, 0);
                            //TimeSpan timeNow = TimeSpan.Parse("13:15");


                            foreach (var i in listTimeOffBusy)
                            {
                                if (TimeSpan.Parse(i.StartTime) > timeNow)
                                {
                                    TimeSpan Hours_Busy = TimeSpan.Parse(i.EndTime) - TimeSpan.Parse(i.StartTime);
                                    int SlotBusy = (int)Hours_Busy.TotalHours / DurationPerAppointment;
                                    TimeBusy += SlotBusy;
                                }
                            }
                        }
                        else
                        {
                            foreach (var i in listTimeOffBusy)
                            {
                                TimeSpan Hours_Busy = TimeSpan.Parse(i.EndTime) - TimeSpan.Parse(i.StartTime);
                                int SlotBusy = (int)Hours_Busy.TotalHours / DurationPerAppointment;
                                TimeBusy += SlotBusy;
                            }
                        }
                        availableTimeSlots -= TimeBusy;
                    }


                    //get break time from time off 
                    var TimeOffBreak = listTimeOff.Where(e => e.Status == AppNumber.BREAK).FirstOrDefault();
                    if (TimeOffBreak != null)
                    {
                        int TimeBreak = 0;
                        if (d == DateTime.Now.Date)
                        {
                            DateTime now = DateTime.Now;
                            TimeSpan timeNow = new TimeSpan(now.Hour, now.Minute, 0);
                            //TimeSpan timeNow = TimeSpan.Parse("13:15"); 

                            if (TimeSpan.Parse(TimeOffBreak.StartTime) > timeNow)
                            {
                                TimeSpan Hours_Break = TimeSpan.Parse(TimeOffBreak.EndTime) - TimeSpan.Parse(TimeOffBreak.StartTime);
                                int SlotBreak = (int)Hours_Break.TotalHours / DurationPerAppointment;
                                TimeBreak += SlotBreak;
                            }
                            else if(TimeSpan.Parse(TimeOffBreak.StartTime) <= timeNow && TimeSpan.Parse(TimeOffBreak.EndTime) > timeNow)
                            {
                                TimeSpan Hours_Break = TimeSpan.Parse(TimeOffBreak.EndTime) - timeNow;
                                int SlotBreak = (int)Hours_Break.TotalHours / DurationPerAppointment;
                                TimeBreak += SlotBreak;
                            }
                        }
                        else
                        {
                            TimeSpan Hours_Break = TimeSpan.Parse(TimeOffBreak.EndTime) - TimeSpan.Parse(TimeOffBreak.StartTime);
                            int SlotBreak = (int)Hours_Break.TotalHours / DurationPerAppointment;
                            TimeBreak += SlotBreak;
                        }
                        availableTimeSlots -= TimeBreak;

                    }
                }

                //get appointment in a day 
                int appointments = GetTotalAppointmentByIdDoctor(d, idDoctor); // Calculate number of Appointment in remain hour Today
                availableTimeSlots = availableTimeSlots - appointments;

                return availableTimeSlots > 0 ? availableTimeSlots : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public Doctor? GetDoctorByIdUser(Guid id)
        {
            var data = _context.Doctors.Include(p => p.User).Include(q => q.MedicalSpecialty).FirstOrDefault(e => e.IdUser == id);
            if (data != null)
                return data;
            return null;
        }
    }
}
