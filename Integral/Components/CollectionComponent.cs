using Integral.Abstractions;
using Integral.Collections;
using Integral.Compositions;

namespace Integral.Components
{
    public abstract class CollectionComponent<Key, Element> : IdentifiableCollection<Key, Element>, Component
        where Element : Identifiable<Key>
        where Key : notnull
    {
        protected CollectionComponent(Composition composition) : base(new IndexedCollection<Key, Element>()) => Composition = composition;

        public Composition Composition { get; }
    }
}
