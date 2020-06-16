using System.Collections;
using System.Collections.Generic;
using Integral.Abstractions;

namespace Integral.Enumerables
{
    public abstract class AbstractEnumerable<Element> : Enumerable<Element>
        where Element : notnull
    {
        public abstract IEnumerator<Element> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}