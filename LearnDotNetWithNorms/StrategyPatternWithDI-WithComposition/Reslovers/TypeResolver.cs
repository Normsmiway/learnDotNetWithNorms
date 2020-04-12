using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternWithDI_WithComposition.Reslovers
{
    public class TypeResolver<T> : ITypeResolver<T> where T : IResolvableType
    {
        private readonly IEnumerable<T> _types;
        public TypeResolver(IEnumerable<T> types)
        {
            _types = types;
        }
        public T Resolve(string name)
        {
            var _type = _types.FirstOrDefault(type => type.Name.ToLowerInvariant() == name.ToLowerInvariant());
            if (_type == null)
            {
                throw new ArgumentException($"Unrecognised {typeof(T)}");
            }

            return _type;
        }

    }
}
