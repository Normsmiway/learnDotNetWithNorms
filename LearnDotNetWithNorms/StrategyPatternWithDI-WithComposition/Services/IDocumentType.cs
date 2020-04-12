using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition.Reslovers;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Services
{
    public interface IDocumentType
    {
        Task<Document> Process(DocumentRequest request);
    }
}
