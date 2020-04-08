using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI.Services
{
    public interface IDocumentTypeResolver
    {
        IDocumentType Resolve(string name);
    }
}
