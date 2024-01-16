using Microsoft.Identity.Client;

namespace HIS.Appointment.VIewModel
{
    public class MakeAppointmentViewModel
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public DateTime DateOption { get; set; }
    }
}
