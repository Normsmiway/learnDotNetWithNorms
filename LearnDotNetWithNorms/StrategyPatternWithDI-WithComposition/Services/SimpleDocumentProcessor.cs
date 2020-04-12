using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition_WithComposition.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public class SimpleDocumentProcessor : IDocumentProcessor
    {
        public string Name => nameof(SimpleDocumentProcessor);

        public async Task<Document> Process(DocumentRequest request)
        {
            return await Task.FromResult(new Document() { Name = nameof(HtmlDocument), Description = $"Document of Type {nameof(HtmlDocument)} processed successfully" });
        }
    }
}
