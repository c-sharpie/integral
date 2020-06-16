using System.Collections.Concurrent;

namespace Integral.Collections
{
    public class ConcurrentIndexedCollection<Key, Element> : ConcurrentDictionary<Key, Element>, KeyedCollection<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        public bool Add(Key key, Element element) => TryAdd(key, element);

        public bool Peek(Key key, out Element element) => TryGetValue(key, out element);

        public bool Remove(Key key, out Element element) => TryRemove(key, out element);
    }
}