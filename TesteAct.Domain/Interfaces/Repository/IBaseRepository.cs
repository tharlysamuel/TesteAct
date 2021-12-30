using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task Add(T item);
        Task Update(T item);
        Task<List<T>> List();
    }
}
