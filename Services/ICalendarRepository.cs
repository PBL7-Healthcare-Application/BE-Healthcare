using BE_Healthcare.Models;

namespace BE_Healthcare.Services
{
    public interface ICalendarRepository
    {
        ApiResponse GetCalendar(Guid id);
        ApiResponse CreateTimeOff(Guid id, List<InformationTimeOffModel> listCreateTimeOff);
        void Save();

    }
}
