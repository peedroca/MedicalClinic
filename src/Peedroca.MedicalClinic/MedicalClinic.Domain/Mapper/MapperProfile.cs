using AutoMapper;
using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }
}
