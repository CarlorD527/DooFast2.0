using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Restaurante : ClaseBase
    {

        public string NombreRestaurante { get; set; }

        public string Direccion { get; set; }

    }
}
