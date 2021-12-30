using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteAct.Domain;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Domain.Interfaces.Services;

namespace TesteAct.Service
{
    public class RegistroOperacoesService : IRegistroOperacoesService
    {
        private IRegistroOperacoesRepository _repository;
        public RegistroOperacoesService(IRegistroOperacoesRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(RegistroOperacoes Objeto)
        {
            await _repository.Add(Objeto);
        }
        public async Task Delete(Guid Id)
        {
            await _repository.Delete(Id);
        }
        public async Task<RegistroOperacoes> GetEntityById(Guid Id)
        {
            return await _repository.GetEntityById(Id);
        }

        public async Task<List<RegistroOperacoes>> GetEntityByAcao(string Id)
        {
            return await _repository.GetEntityByAcao(Id);
        }

        public async Task<List<RegistroOperacoes>> List()
        {
            return await _repository.List();
        }

        public async Task Update(RegistroOperacoes Objeto)
        {
            await _repository.Update(Objeto);
        }
    }
}
