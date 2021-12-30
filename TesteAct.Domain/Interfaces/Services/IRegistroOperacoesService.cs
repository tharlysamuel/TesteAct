using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Services
{
    public interface IRegistroOperacoesService: IBaseService<RegistroOperacoes>
    {
        Task Delete(Guid Id);
        Task<RegistroOperacoes> GetEntityById(Guid Id);

        Task<List<RegistroOperacoes>> GetEntityByAcao(string Id);
    }
}
