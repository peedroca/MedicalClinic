using MedicalClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Infra.Data.Mapping
{
    /// <summary>
    /// Mapeamento de Agendamento
    /// </summary>
    public class ScheduleMap : IEntityTypeConfiguration<ScheduleEntity>
    {
        public void Configure(EntityTypeBuilder<ScheduleEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
