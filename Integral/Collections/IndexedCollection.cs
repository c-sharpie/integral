using System.Collections.Generic;

namespace Integral.Collections
{
    public class IndexedCollection<Key, Element> : Dictionary<Key, Element>, KeyedCollection<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        public new bool Add(Key key, Element element) => TryAdd(key, element);

        public bool Peek(Key key, out Element element) => TryGetValue(key, out element!);
    }
}