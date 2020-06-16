using System.Collections;
using System.Collections.Generic;

namespace Integral.Abstractions
{
    public interface Enumerable : IEnumerable
    {
    }

    public interface Enumerable<out Element> : IEnumerable<Element>
        where Element : notnull
    {
    }
}