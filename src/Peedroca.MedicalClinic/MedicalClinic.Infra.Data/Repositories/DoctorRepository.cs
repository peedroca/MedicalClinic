using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalClinic.Infra.Data.Repositories
{
    /// <summary>
    /// Repositório Médico
    /// </summary>
    public class DoctorRepository : IDoctorRepository
    {
        private MedicalClinicDbContext _context;

        public DoctorRepository(MedicalClinicDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DoctorEntity> GetDoctors()
        {
            return _context.Doctors
                .AsNoTracking()
                .ToList();
        }

        public void SaveDoctor(DoctorEntity entity)
        {
            if (entity.Id == 0)
                _context.Add(entity);
            else
                _context.Update(entity);

            _context.SaveChanges();
        }
    }
}
