using MessageProcessor.Parser;
using MessageProcessor.Resolvers;
using MessageProcessor.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Compositions
{
    public class DefaultMessageComposer : IMessageComposer
    {
        public string Name => nameof(DefaultMessageComposer);
        private readonly ITypeResolver<IMessageSourceStrategy> _messageSourcetypeResolver;
        private readonly ITypeResolver<IMessageParserStrategy> _messageParserResolver;

        public DefaultMessageComposer()
        {

        }

        public Task Compose()
        {
            throw new NotImplementedException();
        }
    }
}
