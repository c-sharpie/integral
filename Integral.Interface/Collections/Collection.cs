using Integral.Abstractions;

namespace Integral.Collections
{
    public interface Collection<out Element> : Enumerable<Element>, Countable, Clearable
        where Element : notnull
    {
    }
}