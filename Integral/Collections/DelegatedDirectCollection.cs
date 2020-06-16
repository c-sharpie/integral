using System;

namespace Integral.Collections
{
    public class DelegatedDirectCollection<Key, Element> : VirtualDirectCollection<Key, Element>, ObservableCollection<Element>
        where Key : notnull
        where Element : notnull
    {
        public DelegatedDirectCollection(DirectCollection<Key, Element> directCollection) : base(directCollection)
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

        public override bool Remove(Element element)
        {
            bool success = base.Remove(element);
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