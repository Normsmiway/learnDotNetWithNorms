using StrategyPatternWithDI.Constants;
using StrategyPatternWithDI.Requests;
using StrategyPatternWithDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public class PdfDocument : IDocumentType
    {
        public string Name { get; private set; }

        public PdfDocument()
        {
            Name = DocumentType.Pdf;
        }

        public async Task<Document> Process(DocumentRequest request)
        {
            return await Task.FromResult(new Document() { Name = nameof(PdfDocument), Description = $"Document of Type {nameof(PdfDocument)} processed successfully" });
        }
    }
}
