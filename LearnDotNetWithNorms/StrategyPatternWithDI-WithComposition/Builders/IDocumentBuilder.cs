using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public interface IDocumentBuilder
    {
        Task<Document> Build(string name, DocumentRequest request);
    }
}
