using HIS.Appointment.VIewModel;
using Microsoft.AspNetCore.Mvc;

namespace HIS.Appointment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AppointmentResponseViewModel> GetAppointments(AppointmentQueryViewModel queryViewModel)
        {
            return new List<AppointmentResponseViewModel>();
        }

        [HttpPost]
        public void MakeAppointment(MakeAppointmentViewModel makeAppointmentViewModel) { }

        [HttpDelete]
        public void CancelAppointment(CancelAppointmentViewModel cancelAppointmentViewModel) { }
    }
}
