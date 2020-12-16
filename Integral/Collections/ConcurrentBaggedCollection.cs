using System.Collections.Concurrent;

namespace Integral.Collections
{
    public class ConcurrentBaggedCollection<Element> : ConcurrentBag<Element>, IndirectCollection<Element>
        where Element : notnull
    {
        public new bool Add(Element element)
        {
            base.Add(element);
            return true;
        }

        public bool Remove(out Element element) => TryTake(out element!);

        public bool Peek(out Element element) => TryPeek(out element!);
    }
}