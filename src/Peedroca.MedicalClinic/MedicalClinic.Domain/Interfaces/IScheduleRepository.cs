using MedicalClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositório de agendamentos
    /// </summary>
    public interface IScheduleRepository
    {
        void SaveSchedule(ScheduleEntity entity);

        IEnumerable<ScheduleEntity> GetSchedules();

        ScheduleEntity GetScheduleById(long id);

        void DeleteSchedule(ScheduleEntity entity);
    }
}
