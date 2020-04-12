using System;
using System.Collections.Generic;
using System.Linq;

namespace MessageProcessor.Resolvers
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

            T _type = _types.FirstOrDefault(type => type.Name.ToLowerInvariant() == name.ToLowerInvariant());

            if (_type == null)
            {
                throw new ArgumentException($"Unrecognised {typeof(T)}", name);
            }
            return _type;
        }

    }
}
