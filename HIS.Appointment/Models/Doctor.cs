using System;
using System.Collections.Generic;

namespace HIS.Appointment.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SpecializationId { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
