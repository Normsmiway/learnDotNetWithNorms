using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Handler
{
    public interface IMessageHandler
    {
        Task<string> Execute();
    }
}
