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
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.NombreUsuario).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Correo).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Celular).IsRequired().HasMaxLength(9);
            builder.Property(u => u.Contrasenia).IsRequired().HasMaxLength(256);
            builder.Property(u => u.imagen).IsRequired().HasMaxLength(1000);
            builder.HasOne(r => r.Rol).WithMany().HasForeignKey(u => u.RolId);
            builder.HasOne(res => res.Restaurante).WithMany().HasForeignKey(u => u.RestauranteId);
        }
    }
}
