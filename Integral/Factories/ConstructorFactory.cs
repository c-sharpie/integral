namespace Integral.Factories
{
    public sealed class ConstructorFactory<Product> : Factory<Product>
        where Product : notnull, new()
    {
        public Product Create() => new Product();
    }
}