namespace HIS.Appointment.VIewModel
{
    public class ScheduleDailyViewModel
    {
        public DateOnly ScheduleDate { get; set; }
        public List<ScheduleInfoViewModel> ScheduleInfos { get; set; }
    }
}
