using HIS.Appointment.Profiles;
using HIS.Appointment.Repositories;
using HIS.Appointment.Repositories.Interface;
using HIS.Appointment.Services;
using HIS.Appointment.Services.Interface;
using Microsoft.AspNetCore.Hosting;

namespace HIS.Appointment.Extensions
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ScheduleProfile));
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<IScheduleService, ScheduleService>();
            return services;
        }
    }
}
