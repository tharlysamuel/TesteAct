using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteAct.Domain;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Domain.Interfaces.Services;

namespace TesteAct.Service
{
    public class AcoesService : IAcoesService
    {
        private IAcoesRepository _repository;
        public AcoesService(IAcoesRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(Acoes Objeto)
        {
            await _repository.Add(Objeto);
        }
        public async Task Delete(string Id)
        {
            await _repository.Delete(Id);
        }
        public async Task<Acoes> GetEntityById(string Id)
        {
            return await _repository.GetEntityById(Id);
        }

        public async Task<List<Acoes>> List()
        {
            return await _repository.List();
        }

        public async Task Update(Acoes Objeto)
        {
            await _repository.Update(Objeto);
        }
    }
}
