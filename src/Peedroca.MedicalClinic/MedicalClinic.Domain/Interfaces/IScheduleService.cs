using MedicalClinic.Domain.Models;
using System;
using System.Collections.Generic;

namespace MedicalClinic.Domain.Interfaces
{
    public interface IScheduleService : IDisposable
    {
        ScheduleModel Create(CreateScheduleModel model);

        ScheduleModel Update(UpdateScheduleModel model);

        IEnumerable<ScheduleModel> GetSchedules();

        ScheduleModel GetScheduleById(long id);

        bool Delete(long id);
    }
}
