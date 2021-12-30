using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Services
{
    public interface IAcoesService : IBaseService<Acoes>
    {
        Task Delete(string Id);
        Task<Acoes> GetEntityById(string Id);
    }
}
