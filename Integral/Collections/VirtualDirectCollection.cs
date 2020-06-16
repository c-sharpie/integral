namespace Integral.Collections
{
    public abstract class VirtualDirectCollection<Key, Element> : VirtualCollection<Element>, DirectCollection<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        private readonly DirectCollection<Key, Element> directCollection;

        protected VirtualDirectCollection(DirectCollection<Key, Element> directCollection) : base(directCollection) => this.directCollection = directCollection;

        public Element this[Key key] => directCollection[key];

        public virtual bool Add(Element element) => directCollection.Add(element);

        public virtual bool Remove(Element element) => directCollection.Remove(element);

        public virtual bool Contains(Element element) => directCollection.Contains(element);
    }
}