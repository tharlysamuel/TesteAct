using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Repository
{
    public interface IRegistroOperacoesRepository: IBaseRepository<RegistroOperacoes>
    {
        Task Delete(Guid Id);
        Task<RegistroOperacoes> GetEntityById(Guid Id);

        Task<List<RegistroOperacoes>> GetEntityByAcao(string Id);
    }
}
