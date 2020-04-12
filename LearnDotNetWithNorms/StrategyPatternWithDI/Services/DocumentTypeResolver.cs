using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public class DocumentTypeResolver : IDocumentTypeResolver
    {

        private readonly IEnumerable<IDocumentType> _documentTypes;

        public DocumentTypeResolver(IEnumerable<IDocumentType> documentTypes)
        {
            _documentTypes = documentTypes;
        }
        public IDocumentType Resolve(string name)
        {
            IDocumentType documentType = _documentTypes.FirstOrDefault(docType => docType.Name.ToLowerInvariant() == name.ToLowerInvariant());

            if (documentType == null)
            {
                throw new ArgumentException($"Unrecognised document type ", name);
            }

            return documentType;
        }
    }


   
}
