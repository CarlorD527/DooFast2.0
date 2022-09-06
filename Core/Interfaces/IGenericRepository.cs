using Core.Entities;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : ClaseBase
    {
        //Para las entidades que no tienen relaciones (sin especificaciones y/o filtros)
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> GetAllAsync();



        // las especificaciones sirven para indicar que relaciones y/o condiciones se quieren aplicar a la consulta
        Task<T> GetByIdWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);


    }
}
