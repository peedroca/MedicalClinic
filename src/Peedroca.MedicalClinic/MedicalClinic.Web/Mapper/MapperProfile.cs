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
        }
    }
}
