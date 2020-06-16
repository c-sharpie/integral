namespace Integral.Collections
{
    public abstract class VirtualIndirectCollection<Element> : VirtualCollection<Element>, IndirectCollection<Element>
        where Element : notnull
    {
        private readonly IndirectCollection<Element> indirectCollection;

        protected VirtualIndirectCollection(IndirectCollection<Element> indirectCollection) : base(indirectCollection) => this.indirectCollection = indirectCollection;

        public virtual bool Add(Element element) => indirectCollection.Add(element);

        public virtual bool Remove(out Element element) => indirectCollection.Remove(out element);

        public virtual bool Peek(out Element element) => indirectCollection.Peek(out element);
    }
}