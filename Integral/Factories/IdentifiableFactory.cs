using Integral.Abstractions;

namespace Integral.Factories
{
    public abstract class IdentifiableFactory<Key, Product> : Factory<Product>, Identifiable<Key>
        where Key : notnull
        where Product : notnull, Identifiable<Key>
    {
        protected IdentifiableFactory(Key identity) => Identity = identity;

        public Key Identity { get; }

        public abstract Product Create();
    }
}