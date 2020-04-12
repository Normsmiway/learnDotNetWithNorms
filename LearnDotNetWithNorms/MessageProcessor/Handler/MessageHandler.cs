using MessageProcessor.Options;
using MessageProcessor.Parser;
using MessageProcessor.Resolvers;
using MessageProcessor.Source;
using System.Threading.Tasks;

namespace MessageProcessor.Handler
{
    public class MessageHandler : IMessageHandler
    {
        private readonly ITypeResolver<IMessageParserStrategy> _messageParserTypeResolver;
        private readonly ITypeResolver<IMessageSourceStrategy> _messageSourceTypeResolver;
        private readonly string path;
        private readonly StrategyOptions _stategyOptions;
        public MessageHandler(ITypeResolver<IMessageParserStrategy> messageParserTypeResolver,
                              ITypeResolver<IMessageSourceStrategy> messageSourceTypeResolver,
                              StrategyOptions strategyOptions)
        {
            _messageParserTypeResolver = messageParserTypeResolver;
            _messageSourceTypeResolver = messageSourceTypeResolver;
            _stategyOptions = strategyOptions;
            path = @"C:\Messaging...";
        }

        public async Task<string> Execute()
        {
            var messagesource = _messageSourceTypeResolver.Resolve(_stategyOptions.MessageSource ?? Constants.Strategy.MessageSource.Database);
            var messageParser = _messageParserTypeResolver.Resolve(_stategyOptions.FileParser ?? Constants.Strategy.FileParser.Simple);

            var message = await messagesource.Get(path);
            var result = await messageParser.Parse(message);

            return $"{result}";
        }
    }
}
