using System.Collections.Generic;

namespace Integral.Collections
{
    public class StackedCollection<Element> : Stack<Element>, IndirectCollection<Element>
        where Element : notnull
    {
        public bool Add(Element element)
        {
            Push(element);
            return true;
        }

        public bool Remove(out Element element) => TryPop(out element);

        public bool Peek(out Element element) => TryPeek(out element);
    }
}