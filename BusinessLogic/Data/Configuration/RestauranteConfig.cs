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
    public class RestauranteConfig : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.Property(p => p.NombreRestaurante).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Direccion).IsRequired().HasMaxLength(500);
        }
    }
}
