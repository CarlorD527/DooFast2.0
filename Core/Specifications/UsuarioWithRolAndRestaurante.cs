using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
     
    public class UsuarioWithRolAndRestaurante : BaseSpecification<Usuario>
    {

        public UsuarioWithRolAndRestaurante() {

            AddInclude(u => u.Rol);
            AddInclude(u => u.Restaurante);

        
        }

        public UsuarioWithRolAndRestaurante(int id) : base(x => x.Id == id) {
            AddInclude(u => u.Rol);
            AddInclude(u => u.Restaurante);
        }

    }
}
