using MedicalClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalClinic.Infra.Data.Contexts
{
    public class MedicalClinicDbContext : DbContext
    {
        public MedicalClinicDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Tabela Médico
        /// </summary>
        public DbSet<DoctorEntity> Doctors { get; set; }

        /// <summary>
        /// Tabela Paciênte
        /// </summary>
        public DbSet<PatientEntity> Patients { get; set; }

        /// <summary>
        /// Tabela Agendamento
        /// </summary>
        public DbSet<ScheduleEntity> Schedules { get; set; }
    }
}
