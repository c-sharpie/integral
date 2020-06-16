using System.Collections.Generic;
using Integral.Aggregates;
using Integral.Containers;

namespace Integral.Collections
{
    public class HashedCollection<Element> : HashSet<Element>, DirectAggregate<Element>, Collection<Element>, Container<Element>
        where Element : notnull
    {
    }
}