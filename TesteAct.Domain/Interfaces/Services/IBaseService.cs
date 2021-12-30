using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteAct.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        Task Add(T item);
        Task Update(T item);
        Task<List<T>> List();
    }
}
