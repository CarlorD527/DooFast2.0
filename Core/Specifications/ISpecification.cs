using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        //operaciones - criterio: refiere a la condicion logica de la consulta , includes: implementacion de relaciones entre entidades

        Expression<Func<T,bool>> Criteria { get; }


        //Lista de includes (relaciones) 
        List<Expression<Func<T, object>>> Includes { get; }

    }
}
