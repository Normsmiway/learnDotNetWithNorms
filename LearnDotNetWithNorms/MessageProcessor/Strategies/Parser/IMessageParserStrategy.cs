using MessageProcessor.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Parser
{
    public interface IMessageParserStrategy : IResolvableType
    {
        Task<object> Parse(object rawMessage);
    }
}



