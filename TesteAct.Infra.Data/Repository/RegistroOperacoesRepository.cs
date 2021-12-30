using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAct.Domain;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Infra.Data.Context;

namespace TesteAct.Infra.Data.Repository
{
    public class RegistroOperacoesRepository : BaseRepository<RegistroOperacoes>, IRegistroOperacoesRepository
    {
        protected readonly BaseContext _context;
        private readonly DbSet<RegistroOperacoes> _dataSet;
        public RegistroOperacoesRepository(BaseContext context) : base(context)
        {
            _context = context;
            _dataSet = _context.Set<RegistroOperacoes>();
        }

        public async Task Delete(Guid Id)
        {
            var objeto = await GetEntityById(Id);
            _dataSet.Remove(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task<RegistroOperacoes> GetEntityById(Guid Id)
        {
            return await _dataSet.FindAsync(Id);
        }

        public async Task<List<RegistroOperacoes>> GetEntityByAcao(string Id)
        {
            return await _dataSet.Where(x => x.CodigoAcao == Id).ToListAsync();
        }

    }
}
