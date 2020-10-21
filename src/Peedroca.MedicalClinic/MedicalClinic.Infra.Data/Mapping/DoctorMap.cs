using MedicalClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalClinic.Infra.Data.Mapping
{
    /// <summary>
    /// Mapeamento da tabela médico
    /// </summary>
    public class DoctorMap : IEntityTypeConfiguration<DoctorEntity>
    {
        public void Configure(EntityTypeBuilder<DoctorEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
