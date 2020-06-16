namespace Integral.Factories
{
    public interface Factory<out Product>
        where Product : notnull
    {
        Product Create();
    }
}