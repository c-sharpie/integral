using System.Collections.Generic;
using Integral.Abstractions;

namespace Integral.Collections
{
    public class IdentifiableCollection<Key, Element> : VirtualKeyedCollection<Key, Element>, DirectCollection<Key, Element>
        where Element : Identifiable<Key>
        where Key : notnull
    {
        public IdentifiableCollection(KeyedCollection<Key, Element> keyedCollection) : base(keyedCollection)
        {
        }

        public IdentifiableCollection()
            : this(new IndexedCollection<Key, Element>())
        {
        }

        public virtual bool Add(Element element)
        {
            Add(element.Identity, element);
            return true;
        }

        public virtual bool Remove(Element element) => Remove(element.Identity, out _);

        public virtual bool Contains(Element element) => Peek(element.Identity, out _);

        public new IEnumerator<Element> GetEnumerator()
        {
            foreach (KeyValuePair<Key, Element> keyValuePair in (IEnumerable<KeyValuePair<Key, Element>>)this)
            {
                yield return keyValuePair.Value;
            }
        }
    }
}