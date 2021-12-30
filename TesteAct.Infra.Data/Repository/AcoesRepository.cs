using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteAct.Domain;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Infra.Data.Context;

namespace TesteAct.Infra.Data.Repository
{
    public class AcoesRepository : BaseRepository<Acoes>, IAcoesRepository
    {
        protected readonly BaseContext _context;
        private readonly DbSet<Acoes> _dataSet;
        public AcoesRepository(BaseContext context) : base(context)
        {
            _context = context;
            _dataSet = _context.Set<Acoes>();

        }

        public async Task Delete(string Id)
        {
            var objeto = await GetEntityById(Id);
            _dataSet.Remove(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task<Acoes> GetEntityById(string Id)
        {
            return await _dataSet.FindAsync(Id);
        }

    }
}