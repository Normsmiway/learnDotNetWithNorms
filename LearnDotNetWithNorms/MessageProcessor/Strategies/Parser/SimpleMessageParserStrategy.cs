using MessageProcessor.Constants;
using MessageProcessor.Options;
using MessageProcessor.Resolvers;
using MessageProcessor.Storage;
using System.Threading.Tasks;

namespace MessageProcessor.Parser
{
    public class SimpleMessageParserStrategy : IMessageParserStrategy
    {
        private readonly ITypeResolver<IMessageStoreStrategy> _typeResolver;
        private readonly StrategyOptions _strategyOptions;
        public SimpleMessageParserStrategy(ITypeResolver<IMessageStoreStrategy> typeResolver,StrategyOptions strategyOptions)
        {
            _typeResolver = typeResolver;
            _strategyOptions = strategyOptions;
        }

        public string Name => nameof(SimpleMessageParserStrategy);

        public async Task<object> Parse(object rawMessage)
        {
            //using File Storage for SimpleMessageParserStrategy 
            var resolver = _typeResolver.Resolve(_strategyOptions.MessageStore ?? Strategy.MessageStore.File);

            //save message
            var result= await resolver.Store($"{rawMessage}:\nParsing with: {nameof(SimpleMessageParserStrategy)}\n");
            return result;
           
        }
    }
}
