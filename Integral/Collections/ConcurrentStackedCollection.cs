using System.Collections.Concurrent;

namespace Integral.Collections
{
    public class ConcurrentStackedCollection<Element> : ConcurrentStack<Element>, IndirectCollection<Element>
        where Element : notnull
    {
        public bool Add(Element element)
        {
            Push(element);
            return true;
        }

        public bool Remove(out Element element) => TryPop(out element!);

        public bool Peek(out Element element) => TryPeek(out element!);
    }
}