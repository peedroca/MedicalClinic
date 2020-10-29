using AutoMapper;
using MedicalClinic.Domain.Models;
using MedicalClinic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalClinic.Web.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DoctorModel, DoctorView>();
            CreateMap<CustomerModel, CustomerView>();

            CreateMap<ScheduleModel, ScheduleView>()
                .ForMember(to => to.IdCustomer, from => from.MapFrom(f => f.Customer.Id))
                .ForMember(to => to.NameCustomer, from => from.MapFrom(f => f.Customer.Name))
                .ForMember(to => to.PhoneCustomer, from => from.MapFrom(f => f.Customer.Phone))
                .ForMember(to => to.IdDoctor, from => from.MapFrom(f => f.Doctor.Id))
                .ForMember(to => to.NameDoctor, from => from.MapFrom(f => f.Doctor.Name))
                .ForMember(to => to.PhoneDoctor, from => from.MapFrom(f => f.Doctor.Phone))
                .ForMember(to => to.SpecialtyDoctor, from => from.MapFrom(f => f.Doctor.Specialty));
        }
    }
}
