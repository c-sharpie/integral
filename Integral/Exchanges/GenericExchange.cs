using Integral.Publishers;

namespace Integral.Exchanges
{
    public abstract class GenericExchange<Exchangeable> : GenericPublisher<Exchangeable>, Exchange<Exchangeable>
        where Exchangeable : notnull
    {
        public abstract void OnPublished(Exchangeable exchangeable);
    }
}
