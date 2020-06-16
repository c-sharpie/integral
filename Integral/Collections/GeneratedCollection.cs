using Integral.Factories;

namespace Integral.Collections
{
    public class GeneratedCollection<Element> : VirtualIndirectCollection<Element>
        where Element : notnull
    {
        private readonly Factory<Element> factory;

        public GeneratedCollection(IndirectCollection<Element> indirectCollection, Factory<Element> factory) : base(indirectCollection) => this.factory = factory;

        public override bool Remove(out Element element)
        {
            if (!base.Remove(out element))
            {
                element = factory.Create();
            }

            return true;
        }
    }
}