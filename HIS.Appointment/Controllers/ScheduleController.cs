using AutoMapper;
using HIS.Appointment.ServiceModel;
using HIS.Appointment.Services.Interface;
using HIS.Appointment.VIewModel;
using Microsoft.AspNetCore.Mvc;

namespace HIS.Appointment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;
        private readonly IMapper _mapper;

        public ScheduleController(IScheduleService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IEnumerable<ScheduleDailyViewModel>> GetScheduleAsync([FromBody] ScheduleQueryViewModel queryViewModel)
        {
            var queryServiceModel = _mapper.Map<ScheduleQueryServiceModel>(queryViewModel);
            var respServiceModel = await _service.GetListAsync(queryServiceModel);
            var respViewModel = _mapper.Map<List<ScheduleDailyViewModel>>(respServiceModel);
            return respViewModel;
        }
    }
}
