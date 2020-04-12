using System.Threading.Tasks;

namespace MessageProcessor.FileAccessor
{
    public class LocalFileAccessStrategy : IFileAccessStrategy
    {
        public string Name => nameof(LocalFileAccessStrategy);

        public LocalFileAccessStrategy()
        {
            //Name = "LocalFileAccessor";
        }

        public async Task<object> GetFiles(string path)
        {
            return await Task.Run(() => $"Getting all file from path:{path} using {nameof(Constants.Strategy.FileAccess.Local)}\n");
        }
    }
}
