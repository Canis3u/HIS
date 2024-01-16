using HIS.Appointment.VIewModel;

namespace HIS.Appointment.ServiceModel
{
    public class ScheduleDailyServiceModel
    {
        public DateOnly ScheduleDate { get; set; }
        public List<ScheduleInfoServiceModel> ScheduleInfos { get; set; }
    }
}
