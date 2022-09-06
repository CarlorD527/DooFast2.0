using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data
{
    public class DoofastDbContext : DbContext
    {

        
        public DoofastDbContext(DbContextOptions<DoofastDbContext> options) : base(options) { }


        public DbSet<Restaurante> Restaurante { get; set; }

        public DbSet<Rol> Rol { get; set; }


        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
