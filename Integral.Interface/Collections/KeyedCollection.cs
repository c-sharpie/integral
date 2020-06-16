using System.Collections.Generic;
using Integral.Abstractions;
using Integral.Aggregates;

namespace Integral.Collections
{
    public interface KeyedCollection<Key, Element> : PairedAggregate<Key, Element>, Collection<KeyValuePair<Key, Element>>, Peekable<Key, Element>, Indexable<Key, Element>
        where Key : notnull
        where Element : notnull
    {
    }
}