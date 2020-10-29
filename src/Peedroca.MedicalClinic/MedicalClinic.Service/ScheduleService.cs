using AutoMapper;
using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Models;
using MedicalClinic.Infra.Data.Contexts;
using MedicalClinic.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Service
{
    /// <summary>
    /// Serviço Agendamento
    /// </summary>
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository _repository;
        private IMapper _mapper;

        public ScheduleService(MedicalClinicDbContext context, IMapper mapper)
        {
            _repository = new ScheduleRepository(context);
            _mapper = mapper;
        }

        public ScheduleModel Create(CreateScheduleModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var scheduleEntity = _mapper.Map<ScheduleEntity>(model);
                _repository.SaveSchedule(scheduleEntity);

                return _mapper.Map<ScheduleModel>(scheduleEntity);
            }
            catch (Exception e) 
            {
                throw e;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                var scheduleEntity = _repository.GetScheduleById(id);

                if (scheduleEntity == null)
                    return false;

                _repository.DeleteSchedule(scheduleEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _repository = null;
        }

        public ScheduleModel GetScheduleById(long id)
        {
            try
            {
                var schedule = _repository.GetScheduleById(id);
                return _mapper.Map<ScheduleModel>(schedule);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ScheduleModel> GetSchedules()
        {
            try
            {
                var schedules = _repository.GetSchedules();
                return _mapper.Map<IEnumerable<ScheduleModel>>(schedules);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ScheduleModel Update(UpdateScheduleModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var ScheduleEntity = _mapper.Map<ScheduleEntity>(model);
                _repository.SaveSchedule(ScheduleEntity);

                return _mapper.Map<ScheduleModel>(ScheduleEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}