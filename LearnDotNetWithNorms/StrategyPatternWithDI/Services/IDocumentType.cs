using StrategyPatternWithDI.Models;
using StrategyPatternWithDI.Requests;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public interface IDocumentType 
    {
        string Name { get; set; }
        Task<Document> Process(DocumentRequest request);
    }
}
