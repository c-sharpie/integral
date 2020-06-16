using System.Collections.Generic;
using System.Linq;
using Integral.Collections;
using Integral.Components;

namespace Integral.Compositions
{
    public abstract class ComponentComposition : ListedCollection<Component>, Composition
    {
        public bool Any<Element>()
            where Element : Component => this.OfType<Element>().Any();

        public Element First<Element>()
            where Element : Component => this.OfType<Element>().First();

        public Element Single<Element>()
            where Element : Component => this.OfType<Element>().Single();

        public IEnumerable<Element> All<Element>()
            where Element : Component => this.OfType<Element>();
    }
}