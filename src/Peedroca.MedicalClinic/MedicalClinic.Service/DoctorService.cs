using AutoMapper;
using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Models;
using MedicalClinic.Infra.Data.Contexts;
using MedicalClinic.Infra.Data.Repositories;
using System;
using System.Collections.Generic;

namespace MedicalClinic.Service
{
    /// <summary>
    /// Serviço Médico
    /// </summary>
    public class DoctorService : IDoctorService
    {
        private IDoctorRepository _repository;
        private IMapper _mapper;

        public DoctorService(MedicalClinicDbContext context, IMapper mapper)
        {
            _repository = new DoctorRepository(context);
            _mapper = mapper;
        }

        public DoctorModel Create(CreateDoctorModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var doctorEntity = _mapper.Map<DoctorEntity>(model);
                _repository.SaveDoctor(doctorEntity);

                return _mapper.Map<DoctorModel>(doctorEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _repository = null;
        }

        public IEnumerable<DoctorModel> GetDoctors()
        {
            try
            {
                var doctors = _repository.GetDoctors();
                return _mapper.Map<IEnumerable<DoctorModel>>(doctors);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DoctorModel Update(UpdateDoctorModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var doctorEntity = _mapper.Map<DoctorEntity>(model);
                _repository.SaveDoctor(doctorEntity);

                return _mapper.Map<DoctorModel>(doctorEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
