using AutoMapper;
using HIS.Appointment.Models;
using HIS.Appointment.Repositories.Interface;
using HIS.Appointment.ServiceModel;
using HIS.Appointment.Services.Interface;
using System.Linq.Expressions;

namespace HIS.Appointment.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _repository;
        private readonly IMapper _mapper;

        public ScheduleService(IScheduleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ScheduleDailyServiceModel>> GetListAsync(ScheduleQueryServiceModel queryServiceModel)
        {
            Expression<Func<Schedule, bool>> predicate = x => true;
            var schedules = await _repository.GetListAsync(predicate);
            var infos = _mapper.Map<List<ScheduleInfoServiceModel>>(schedules);
            var dailys = ProcessScheduleInfo(infos);
            return dailys;
        }

        private List<ScheduleDailyServiceModel> ProcessScheduleInfo(List<ScheduleInfoServiceModel> infos) 
        {
            var dailys = infos
            .GroupBy(info => info.ScheduleDate)
            .Select(group => new ScheduleDailyServiceModel
            {
                ScheduleDate = group.Key,
                ScheduleInfos = group.ToList()
            })
            .ToList();
            return dailys;
        }
    }
}
