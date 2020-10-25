using MedicalClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Infra.Data.Mapping
{
    /// <summary>
    /// Mapeamento do Paciênte
    /// </summary>
    public class CustomerMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}
