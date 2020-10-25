using AutoMapper;
using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Models;

namespace MedicalClinic.Domain.Mapper
{
    /// <summary>
    /// Perfil de mapeamento
    /// </summary>
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateDoctorModel, DoctorEntity>();
            CreateMap<UpdateDoctorModel, DoctorEntity>();
            CreateMap<DoctorEntity, DoctorModel>();

            CreateMap<CreateCustomerModel, CustomerEntity>();
            CreateMap<UpdateCustomerModel, CustomerEntity>();
            CreateMap<CustomerEntity, CustomerModel>();

            CreateMap<CreateScheduleModel, ScheduleEntity>();
            CreateMap<UpdateScheduleModel, ScheduleEntity>();
            CreateMap<ScheduleEntity, ScheduleModel>();
        }
    }
}
