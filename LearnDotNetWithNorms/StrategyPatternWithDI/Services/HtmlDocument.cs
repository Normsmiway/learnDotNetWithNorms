using StrategyPatternWithDI.Constants;
using StrategyPatternWithDI.Requests;
using StrategyPatternWithDI.Models;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public class HtmlDocument : IDocumentType
    {
        public string Name { get; private set; }

        public HtmlDocument()
        {
            Name = DocumentType.Html;
        }

        public async Task<Document> Process(DocumentRequest request)
        {
            return await Task.FromResult(new Document() { Name = nameof(HtmlDocument), Description = $"Document of Type {nameof(HtmlDocument)} processed successfully" });
        }

    }
}
