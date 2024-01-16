using HIS.Appointment.Models;
using System.Linq.Expressions;

namespace HIS.Appointment.Repositories.Interface
{
    public interface IScheduleRepository
    {
        Task<IEnumerable<Schedule>> GetListAsync(Expression<Func<Schedule, bool>> branchPredicate);
    }
}
