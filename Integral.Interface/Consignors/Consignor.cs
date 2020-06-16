using Integral.Consumers;
using Integral.Producers;

namespace Integral.Consignors
{
    public interface Consignor<Product> : Producer<Product>, Consumer<Product>
        where Product : notnull
    {
    }
}