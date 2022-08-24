using Menpos.Domain.Models;
using Menpos.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Persistence.ModelConfigurations
{
    public class EmpresaConfig : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {


            //Base Model Configurations//
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.CreatedBy).HasMaxLength(StandardAttributeLength.SmallString);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.UpdatedBy).HasMaxLength(StandardAttributeLength.SmallString);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.EstablecimientoId).IsRequired();


            builder.Property(x => x.RFC).HasMaxLength(StandardAttributeLength.SmallString);
            builder.Property(x => x.RFC).IsRequired();
            builder.Property(x => x.RazonSocial).HasMaxLength(StandardAttributeLength.MediumString);
            builder.Property(x => x.RazonSocial).IsRequired();
            builder.Property(x => x.NombreComercial).HasMaxLength(StandardAttributeLength.MediumString);
            builder.Property(x => x.NombreComercial).IsRequired();
            builder.Property(x => x.TitularId).IsRequired();
            builder.Property(x => x.MonedaStandardId).IsRequired();


        }
    }
}
