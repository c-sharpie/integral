using System;

namespace Integral.Collections
{
    public class DelegatedIndirectCollection<Element> : VirtualIndirectCollection<Element>, ObservableCollection<Element>
        where Element : notnull
    {
        public DelegatedIndirectCollection(IndirectCollection<Element> indirectCollection) : base(indirectCollection)
        {
        }

        public event Action<Element>? OnAdd;

        public event Action<Element>? OnRemove;

        public override bool Add(Element element)
        {
            if (base.Add(element))
            {
                OnAdd?.Invoke(element);
                return true;
            }

            return false;
        }

        public override bool Remove(out Element element)
        {
            bool success = base.Remove(out element);
            OnRemove?.Invoke(element);
            return success;
        }

        public override void Clear()
        {
            foreach (Element element in this)
            {
                OnRemove?.Invoke(element);
            }

            base.Clear();
        }
    }
}