using HIS.Appointment.ServiceModel;

namespace HIS.Appointment.Services.Interface
{
    public interface IScheduleService
    {
        Task<IEnumerable<ScheduleDailyServiceModel>> GetListAsync(ScheduleQueryServiceModel queryServiceModel);
    }
}
