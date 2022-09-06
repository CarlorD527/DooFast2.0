using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data.Configuration
{
    public class RolConfig : IEntityTypeConfiguration<Rol>
    {

        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.Property(p => p.NombreRol).IsRequired().HasMaxLength(40);
            builder.Property(p => p.FechaCreacion).IsRequired();
            
        }
    }
}
