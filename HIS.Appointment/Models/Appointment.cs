using System;
using System.Collections.Generic;

namespace HIS.Appointment.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public int ScheduleId { get; set; }

    public DateOnly AppointmentDate { get; set; }

    public TimeOnly AppointmentTime { get; set; }

    public bool IsCancelled { get; set; }

    public string AppointmentStatus { get; set; } = null!;

    public string? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
