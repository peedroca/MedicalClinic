using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MedicalClinic.Infra.Data.Repositories
{
    class ScheduleRepository : IScheduleRepository
    {
        private MedicalClinicDbContext _context;

        public ScheduleRepository(MedicalClinicDbContext context)
        {
            _context = context;
        }

        public void DeleteSchedule(ScheduleEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public ScheduleEntity GetScheduleById(long id)
        {
            return _context.Schedules
                .AsNoTracking()
                .Where(w => w.Id == id)
                .SingleOrDefault();
        }

        public IEnumerable<ScheduleEntity> GetSchedules()
        {
            return _context.Schedules
                .AsNoTracking()
                .ToList();
        }

        public void SaveSchedule(ScheduleEntity entity)
        {
            if (entity.Id == 0)
                _context.Add(entity);
            else
                _context.Update(entity);

            _context.SaveChanges();
        }
    }
}
