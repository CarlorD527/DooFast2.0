using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Usuario : ClaseBase
    {

        public Restaurante Restaurante { get; set; }
        public int RestauranteId { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; }

        public string Contrasenia { get; set; }

        public string NombreUsuario { get; set; }

        public string Celular { get; set; }

        public string Correo { get; set; }
        
        public string imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
