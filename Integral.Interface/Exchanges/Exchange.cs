using Integral.Publishers;
using Integral.Subscribers;

namespace Integral.Exchanges
{
    public interface Exchange<Exchangeable> : Publisher<Exchangeable>, Subscriber<Exchangeable>
        where Exchangeable : notnull
    {
    }
}