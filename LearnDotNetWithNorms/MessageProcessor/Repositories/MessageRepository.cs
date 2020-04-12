using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public async Task Add(object message)
        {
           await Task.CompletedTask;
        }

        public async Task Delete(object message)
        {
            await Task.CompletedTask;
        }

        public async Task<object> Get(object id)
        {
            return await Task.Run(() => $"Getting Single Message with id:{id} from database using {nameof(MessageRepository)}\n");
        }

        public async Task<object> GetAll()
        {
            return await Task.Run(() => $"Getting all messages from database using {nameof(MessageRepository)}\n");
        }

        public async Task Update(object message)
        {
            await Task.CompletedTask;
        }
    }
}
