using AutoMapper;
using HIS.Appointment.Models;
using HIS.Appointment.ServiceModel;
using HIS.Appointment.VIewModel;

namespace HIS.Appointment.Profiles
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile() 
        {
            CreateMap<ScheduleQueryViewModel, ScheduleQueryServiceModel>();

            CreateMap<ScheduleDailyServiceModel, ScheduleDailyViewModel>();
            CreateMap<ScheduleInfoServiceModel, ScheduleInfoViewModel>();
            CreateMap<Schedule, ScheduleInfoServiceModel>()
                .ForMember(
                    member => member.DoctorName,
                    opt => opt.MapFrom(src => $"{src.Doctor.FirstName}{src.Doctor.LastName}")
                );
        }
    }
}
