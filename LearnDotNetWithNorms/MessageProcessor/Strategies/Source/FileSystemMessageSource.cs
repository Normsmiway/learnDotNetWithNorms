using MessageProcessor.Options;
using MessageProcessor.Constants;
using MessageProcessor.FileAccessor;
using MessageProcessor.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Source
{
    public class FileSystemMessageSource : IMessageSourceStrategy
    {
        private readonly ITypeResolver<IFileAccessStrategy> _typeResolver;
        private readonly StrategyOptions _options;
        public FileSystemMessageSource(ITypeResolver<IFileAccessStrategy> typeResolver, StrategyOptions options)
        {
            _typeResolver = typeResolver;
            _options = options;
        }

        public string Name => nameof(FileSystemMessageSource);

        public async Task<object> Get(string path)
        {
            var resolver = _typeResolver.Resolve(_options.FileAccess ?? Strategy.FileAccess.Network);
            return await resolver.GetFiles(path);
        }
    }
}
