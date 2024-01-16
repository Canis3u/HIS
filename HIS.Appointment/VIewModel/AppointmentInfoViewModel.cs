namespace HIS.Appointment.VIewModel
{
    public class AppointmentInfoViewModel
    {
        public int AppointmentId { get; set; }
        public int ScheduleId { get; set; }
        public string DoctorName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SerialNumber { get; set; }
        public string Status { get; set; }
    }
}
