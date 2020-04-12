using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProcessor.Resolvers
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
