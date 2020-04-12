using StrategyPatternWithDI_WithComposition.Constants;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition.Models;
using System.Threading.Tasks;
using StrategyPatternWithDI_WithComposition_WithComposition.Services;
using StrategyPatternWithDI_WithComposition.Reslovers;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public class HtmlDocument : IDocumentType
    {
        private readonly ITypeResolver<IDocumentProcessor> _typeResolver;
        public string Name { get; private set; }

        public HtmlDocument(ITypeResolver<IDocumentProcessor> typeResolver)
        {
            Name = DocumentType.Html;
            _typeResolver = typeResolver;
        }

        //As an example, Html is processed by Simple Document Processing Strategy...
        public async Task<Document> Process(DocumentRequest request)
        {
            var resolver = _typeResolver.Resolve(nameof(SimpleDocumentProcessor));
            return await resolver.Process(request);
        }

    }
}
