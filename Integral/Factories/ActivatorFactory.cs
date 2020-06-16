using System;

namespace Integral.Factories
{
    public sealed class ActivatorFactory<Product> : Factory<Product>
        where Product : notnull
    {
        public Product Create() => Activator.CreateInstance<Product>();
    }
}