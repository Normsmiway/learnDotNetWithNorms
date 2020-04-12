using StrategyPatternWithDI_WithComposition.Constants;
using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition.Reslovers;
using StrategyPatternWithDI_WithComposition_WithComposition.Services;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public class PdfDocument : IDocumentType
    {
        private readonly ITypeResolver<IDocumentProcessor> _typeResolver;
        public string Name { get; private set; }

        public PdfDocument(ITypeResolver<IDocumentProcessor> typeResolver)
        {
            Name = DocumentType.Pdf;
            _typeResolver = typeResolver;
        }

        public async Task<Document> Process(DocumentRequest request)
        {
            var resolver = _typeResolver.Resolve(nameof(ComplexDocumentProcessor));
            return await resolver.Process(request);
        }
    }
}
