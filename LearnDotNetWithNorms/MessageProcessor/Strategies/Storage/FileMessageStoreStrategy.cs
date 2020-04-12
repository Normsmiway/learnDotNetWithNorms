using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Storage
{
    public class FileMessageStoreStrategy : IMessageStoreStrategy
    {

        public string Name => nameof(FileMessageStoreStrategy);

        public async Task<object> RetriveAll()
        {
            return await Task.Run(() => $"Get All Messages: using {Constants.Strategy.MessageStore.File}\n");
        }

        public async Task<object> RetriveSigle(object id)
        {
            return await Task.Run(() => $"Get Single Message  with Id: {id} using {Constants.Strategy.MessageStore.File}\n");
        }

        public async Task<string> Store(object message)
        {
           return await Task.Run(() => $"{message}\nSaving Message into file using {Constants.Strategy.MessageStore.File}");
        }
    }
}
