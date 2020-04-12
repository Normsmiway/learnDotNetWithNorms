using MessageProcessor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Source
{
    public class DatabaseSource : IMessageSourceStrategy
    {
        public string Name => nameof(DatabaseSource);

        private readonly IMessageRepository _messageRepository;
        public DatabaseSource(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<object> Get(string path)
        {
            return await _messageRepository.Get(path);
        }
    }
}
