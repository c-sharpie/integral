using System.Collections.Generic;

namespace Integral.Collections
{
    public class ListedCollection<Element> : List<Element>, DirectCollection<int, Element>
        where Element : notnull
    {
        public new virtual bool Add(Element value)
        {
            base.Add(value);
            return true;
        }

        protected void Swap(int index1, int index2)
        {
            Element element = this[index1];
            this[index1] = this[index2];
            this[index2] = element;
        }
    }
}