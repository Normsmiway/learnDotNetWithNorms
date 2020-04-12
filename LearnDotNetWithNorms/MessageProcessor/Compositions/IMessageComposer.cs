using MessageProcessor.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Compositions
{
    public interface IMessageComposer : IResolvableType
    {
        Task Compose();
    }
}
