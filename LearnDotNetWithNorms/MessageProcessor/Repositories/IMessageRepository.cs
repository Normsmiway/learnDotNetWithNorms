using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Repositories
{
    public interface IMessageRepository
    {
        Task Add(object message);
        Task Delete(object message);
        Task Update(object message);
        Task<object> Get(object id);
        Task<object> GetAll();
    }
}
