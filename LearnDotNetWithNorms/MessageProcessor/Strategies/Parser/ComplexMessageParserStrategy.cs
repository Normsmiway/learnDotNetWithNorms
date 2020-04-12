using MessageProcessor.Constants;
using MessageProcessor.Options;
using MessageProcessor.Resolvers;
using MessageProcessor.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Parser
{
    public class ComplexMessageParserStrategy : IMessageParserStrategy
    {
        private readonly ITypeResolver<IMessageStoreStrategy> _typeResolver;
        private readonly StrategyOptions _strategyOptions;
        public ComplexMessageParserStrategy(ITypeResolver<IMessageStoreStrategy> typeResolver, StrategyOptions strategyOptions)
        {
            _typeResolver = typeResolver;
            _strategyOptions = strategyOptions;
        }
        public string Name => nameof(ComplexMessageParserStrategy);
        public async Task<object> Parse(object rawMessage)
        {
            //using File Storage for SimpleMessageParserStrategy 
            var resolver = _typeResolver.Resolve(_strategyOptions.MessageStore ?? Strategy.MessageStore.Database);

            //save message
            var result = await resolver.Store($"{rawMessage}:\nParsing with: {nameof(ComplexMessageParserStrategy)}\n");
            return result;

        }
    }
}
