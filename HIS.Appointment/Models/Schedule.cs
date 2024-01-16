namespace HIS.Appointment.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int DoctorId { get; set; }

    public DateOnly ScheduleDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Doctor Doctor { get; set; } = null!;
}
