using StrategyPatternWithDI.Models;
using StrategyPatternWithDI.Requests;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public class DocumentBuilder : IDocumentBuilder
    {
        //private readonly IDocumentTypeResolver _documentTypeResolver;
        private readonly ITypeResolver<IDocumentType> _typeResolver;

        //public DocumentBuilder(IDocumentTypeResolver documentTypeResolver)
        //{
        //    _documentTypeResolver = documentTypeResolver;
        //}

        public DocumentBuilder(ITypeResolver<IDocumentType> typeResolver)
        {
            _typeResolver = typeResolver;
        }
        //public async Task<Document> Build(string documentTypeName, DocumentRequest request)
        //{
        //    IDocumentType documentType = _documentTypeResolver.Resolve(documentTypeName);
        //    return await Task.FromResult(await documentType.Process(request));

        //}

        public async Task<Document> Build(string documentTypeName, DocumentRequest request)
        {
            IDocumentType documentType = _typeResolver.Resolve(documentTypeName);
            return await Task.FromResult(await documentType.Process(request));

        }
    }
}
