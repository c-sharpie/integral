using Integral.Abstractions;
using Integral.Aggregates;
using Integral.Containers;

namespace Integral.Collections
{
    public interface DirectCollection<in Key, Element> : DirectAggregate<Element>, Collection<Element>, Container<Element>, Indexable<Key, Element>
        where Key : notnull
        where Element : notnull
    {
    }
}