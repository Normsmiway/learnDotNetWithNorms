using MessageProcessor.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.FileAccessor
{
    public interface IFileAccessStrategy : IResolvableType
    {
        Task<object> GetFiles(string path);
    }
}
