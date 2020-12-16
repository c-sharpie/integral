using System.Collections.Concurrent;

namespace Integral.Collections
{
    public class ConcurrentQueuedCollection<Element> : ConcurrentQueue<Element>, IndirectCollection<Element>
        where Element : notnull
    {
        public bool Add(Element element)
        {
            Enqueue(element);
            return true;
        }

        public bool Remove(out Element element) => TryDequeue(out element!);

        public bool Peek(out Element element) => TryPeek(out element!);
    }
}