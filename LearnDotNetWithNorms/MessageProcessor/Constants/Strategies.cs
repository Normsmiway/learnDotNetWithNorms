namespace MessageProcessor.Constants
{
    public class Strategy
    {
        internal class FileAccess
        {
            public const string Local = nameof(FileAccessor.LocalFileAccessStrategy); //|| nameof(FileAccessor.NetworkFileAccessor);
            public const string Network = nameof(FileAccessor.NetworkFileStrategy);
        }

        internal class FileParser
        {
            public const string Simple = nameof(Parser.SimpleMessageParserStrategy);
            public const string Complex = nameof(Parser.ComplexMessageParserStrategy);
        }

        internal class MessageSource
        {
            public const string File = nameof(Source.FileSystemMessageSource);
            public const string Database = nameof(Source.DatabaseSource);
        }

        internal class MessageStore
        {
            public const string File = nameof(Storage.FileMessageStoreStrategy);
            public const string Database = nameof(Storage.DatabaseMessageStoreStategy);
        }

    }
}
