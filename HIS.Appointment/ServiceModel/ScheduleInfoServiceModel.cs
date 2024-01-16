namespace HIS.Appointment.ServiceModel
{
    public class ScheduleInfoServiceModel
    {
        public int ScheduleId { get; set; }
        public DateOnly ScheduleDate { get; set; }
        public required string DoctorName { get; set; }
        public string? SubDoctorName { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int NumOfAppointment { get; set; }
        public bool IsActive { get; set; }
    }
}
