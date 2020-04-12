using MessageProcessor.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Storage
{
    public interface IMessageStoreStrategy : IResolvableType
    {
        Task<string> Store(object message);
        Task<object> RetriveSigle(object id);
        Task<object> RetriveAll();
    }
}
