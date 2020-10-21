using MedicalClinic.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MedicalClinic.Service
{
    public class MedicalClinicSettings
    {
        internal MedicalClinicDbContext MedicalClinicDbContext { get; }

        public MedicalClinicSettings(string connectionString)
        {
            MedicalClinicDbContext = new MedicalClinicDbContext(new DbContextOptionsBuilder()
                .UseMySQL(connectionString,
                    x => x.MigrationsAssembly("FinPedro.Infra.Data"))
                .Options);
        }
    }
}
