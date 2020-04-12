using MessageProcessor.Repositories;
using System.Threading.Tasks;

namespace MessageProcessor.Storage
{
    public class DatabaseMessageStoreStategy : IMessageStoreStrategy
    {
        private readonly IMessageRepository _messageRepository;
        public DatabaseMessageStoreStategy(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public string Name => nameof(DatabaseMessageStoreStategy);

        public async Task<object> RetriveAll()
        {
            return await _messageRepository.GetAll();
        }

        public async Task<object> RetriveSigle(object id)
        {
            return await _messageRepository.Get(id);
        }

        public async Task<string> Store(object message)
        {

            await _messageRepository.Add(message);

            return   await Task.Run(() => $"{message}\nSaving Message into database using {Constants.Strategy.MessageStore.Database}"); ;
        }
    }
}
