using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition.Reslovers;
using StrategyPatternWithDI_WithComposition_WithComposition.Services;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public class DocumentBuilder : IDocumentBuilder
    {
        private readonly ITypeResolver<IDocumentProcessor> _tyeResolver;

        public DocumentBuilder(ITypeResolver<IDocumentProcessor> typeResolver)
        {
            _tyeResolver = typeResolver;
            
        }
        public async Task<Document> Build(string documentTypeName, DocumentRequest request)
        {
            IDocumentProcessor documentType = _tyeResolver.Resolve(documentTypeName);
            return await Task.FromResult(await documentType.Process(request));

        }
    }


}
