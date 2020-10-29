using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MedicalClinic.Infra.Data.Repositories
{
    public class ScheduleRepository : IScheduleRepository
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
                .Include(i => i.Customer)
                .Include(i => i.Doctor)
                .SingleOrDefault();
        }

        public IEnumerable<ScheduleEntity> GetSchedules()
        {
            return _context.Schedules
                .AsNoTracking()
                .Include(i => i.Customer)
                .Include(i => i.Doctor)
                .ToList();
        }

        public void SaveSchedule(ScheduleEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
