using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition_WithComposition.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public class ComplexDocumentProcessor : IDocumentProcessor
    {
        public string Name => nameof(ComplexDocumentProcessor);

        public async Task<Document> Process(DocumentRequest request)
        {
            return await Task.FromResult(new Document() { Name = nameof(PdfDocument), Description = $"Document of Type {nameof(PdfDocument)} processed successfully" });
        }
    }
}
