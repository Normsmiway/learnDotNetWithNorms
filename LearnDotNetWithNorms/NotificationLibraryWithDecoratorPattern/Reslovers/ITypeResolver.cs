using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Reslovers
{

    public interface ITypeResolver<T> where T : IInjectableType
    {
        T Resolve(string name);
    }


    public interface IInjectableType
    {
        string Name { get; }
    }
}
