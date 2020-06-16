namespace Integral.Producers
{
    public interface Producer<out Product>
        where Product : notnull
    {
        Product Produce();
    }
}