using System.Threading.Tasks;

namespace MessageProcessor.FileAccessor
{
    public class NetworkFileStrategy : IFileAccessStrategy
    {
        public string Name => nameof(NetworkFileStrategy);

        public NetworkFileStrategy()
        {

        }

        public async Task<object> GetFiles(string path)
        {
            return await Task.Run(() => $"Getting all files from path:{path} using {nameof(Constants.Strategy.FileAccess.Network)}\n");
        }
    }
}
