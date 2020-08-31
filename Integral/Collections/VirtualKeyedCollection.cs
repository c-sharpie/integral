using System.Collections.Generic;

namespace Integral.Collections
{
    public class VirtualKeyedCollection<Key, Element> : VirtualCollection<KeyValuePair<Key, Element>>, KeyedCollection<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        private readonly KeyedCollection<Key, Element> keyedCollection;

        public VirtualKeyedCollection(KeyedCollection<Key, Element> keyedCollection) : base(keyedCollection) => this.keyedCollection = keyedCollection;

        public Element this[Key key]
        {
            get => keyedCollection[key];
            set => keyedCollection[key] = value;
        }

        public virtual bool Add(Key key, Element element) => keyedCollection.Add(key, element);

        public virtual bool Remove(Key key, out Element element) => keyedCollection.Remove(key, out element);

        public virtual bool Peek(Key key, out Element element) => keyedCollection.Peek(key, out element);
    }
}