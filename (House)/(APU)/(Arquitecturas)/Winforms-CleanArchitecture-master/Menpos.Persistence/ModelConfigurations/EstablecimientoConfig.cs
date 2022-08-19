using Menpos.Domain.Models;
using Menpos.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Persistence.ModelConfigurations
{
    class EstablecimientoConfig : IEntityTypeConfiguration<Establecimiento>
    {
        public void Configure(EntityTypeBuilder<Establecimiento> builder)
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

            //Custom Model Configuration//
            builder.Property(x => x.PersonaMoralId).IsRequired();
            builder.Property(x => x.MonedaStandardId).IsRequired();
            builder.Property(x => x.NivelCuentasContablesId).IsRequired();
            builder.Property(x => x.RepositorioLogoId).IsRequired();



        }
    }
}
