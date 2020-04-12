using StrategyPatternWithDI_WithComposition.Models;
using StrategyPatternWithDI_WithComposition.Requests;
using StrategyPatternWithDI_WithComposition.Reslovers;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition_WithComposition.Services
{


    public interface IDocumentProcessor : IResolvableType
    {
        Task<Document> Process(DocumentRequest request);
    }
}
