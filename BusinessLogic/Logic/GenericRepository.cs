using BusinessLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : ClaseBase
    {

        private readonly DoofastDbContext _context;

        public GenericRepository(DoofastDbContext context) {

            _context = context;
        
        }

        //para entidades sin especificaciones (tal cual de la BD)
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }


        // Con especificaciones (relaciones , filtros etc)
        public async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
        {
            return await AppySpecification(spec).ToListAsync();
        }
        public async Task<T> GetByIdWithSpec(ISpecification<T> spec)
        {
            return await AppySpecification(spec).FirstOrDefaultAsync();
        }
        // Metodo que sirve para devolver la data de la entidad generica
        private IQueryable<T> AppySpecification(ISpecification<T> spec)
        {

            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }
    }
}
