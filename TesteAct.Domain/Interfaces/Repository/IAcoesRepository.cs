using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Repository
{
    public interface IAcoesRepository: IBaseRepository<Acoes>
    {
        Task Delete(string Id);
        Task<Acoes> GetEntityById(string Id);
    }
}
