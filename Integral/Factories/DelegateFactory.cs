using System;

namespace Integral.Factories
{
    public sealed class DelegateFactory<Product> : Factory<Product>
        where Product : notnull
    {
        private readonly Func<Product> function;

        public DelegateFactory(Func<Product> function) => this.function = function;

        public Product Create() => function();
    }
}