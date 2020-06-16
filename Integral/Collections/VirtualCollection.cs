using System.Collections;
using System.Collections.Generic;

namespace Integral.Collections
{
    public abstract class VirtualCollection<Element> : Collection<Element>
        where Element : notnull
    {
        private readonly Collection<Element> collection;

        protected VirtualCollection(Collection<Element> collection) => this.collection = collection;

        public int Count => collection.Count;

        public virtual void Clear() => collection.Clear();

        public IEnumerator<Element> GetEnumerator() => collection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}