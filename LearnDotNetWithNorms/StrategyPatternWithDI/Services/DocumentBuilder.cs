using StrategyPatternWithDI.Models;
using StrategyPatternWithDI.Requests;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public class DocumentBuilder : IDocumentBuilder
    {
        private readonly IDocumentTypeResolver _documentTypeResolver;

        public DocumentBuilder(IDocumentTypeResolver documentTypeResolver)
        {
            _documentTypeResolver = documentTypeResolver;
        }
        public async Task<Document> Build(string documentTypeName, DocumentRequest request)
        {
            IDocumentType documentType = _documentTypeResolver.Resolve(documentTypeName);
            return await Task.FromResult(await documentType.Process(request));

        }
    }
}
