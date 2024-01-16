using HIS.Appointment.Models;
using HIS.Appointment.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HIS.Appointment.Repositories
{
    public class ScheduleRepository: IScheduleRepository
    {
        private readonly HisContext _hisContext;

        public ScheduleRepository(HisContext hisContext)
        {
            _hisContext = hisContext;
        }

        public async Task<IEnumerable<Schedule>> GetListAsync(Expression<Func<Schedule, bool>> branchPredicate)
        {
            var schedules = await _hisContext.Schedules.Where(branchPredicate).Include(s => s.Doctor).ToListAsync();
            return schedules;
        }
    }
}
