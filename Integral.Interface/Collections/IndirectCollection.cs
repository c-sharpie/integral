using Integral.Abstractions;
using Integral.Aggregates;

namespace Integral.Collections
{
    public interface IndirectCollection<Element> : IndirectAggregate<Element>, Collection<Element>, Peekable<Element>
        where Element : notnull
    {
    }
}