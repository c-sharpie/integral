using System;
using Integral.Extensions;

namespace Integral.Collections
{
    public sealed class BoxedCollection
    {
        private readonly IndexedCollection<Type, object> indexedCollection = new IndexedCollection<Type, object>();

        public bool Add<Element>(Element element) => indexedCollection.Add(typeof(Element), element!);

        public bool Remove<Element>(out Element element)
            where Element : notnull
        {
            if (indexedCollection.CastedPeek(typeof(Element), out element))
            {
                indexedCollection.Remove(typeof(Element));
                return true;
            }

            element = default!;
            return false;
        }

        public bool Peek<Element>(out Element element)
            where Element : notnull
        {
            if (indexedCollection.CastedPeek(typeof(Element), out element))
            {
                return true;
            }

            element = default!;
            return false;
        }
    }
}