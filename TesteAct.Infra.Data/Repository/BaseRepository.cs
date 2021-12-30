using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Infra.Data.Context;

namespace TesteAct.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BaseContext _context;
        private readonly DbSet<T> _dataSet;
        public BaseRepository(BaseContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task Add(T Objeto)
        {
            await _dataSet.AddAsync(Objeto);
            await _context.SaveChangesAsync();

        }

        public async Task<List<T>> List()
        {
            return await _dataSet.AsNoTracking().ToListAsync();
        }

        public async Task Update(T Objeto)
        {
            _dataSet.Update(Objeto);
            await _context.SaveChangesAsync();
        }
    }
}
