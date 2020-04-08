using StrategyPatternWithDI.Models;
using StrategyPatternWithDI.Requests;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public interface IDocumentBuilder
    {
        Task<Document> Build(string name, DocumentRequest request);
    }
}
