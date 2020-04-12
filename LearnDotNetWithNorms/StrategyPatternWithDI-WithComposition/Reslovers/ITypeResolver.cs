using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Reslovers
{

    public interface ITypeResolver<T> where T : IResolvableType
    {
        T Resolve(string name);
    }


    public interface IResolvableType
    {
        string Name { get; }
    }
}
