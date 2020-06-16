using System;
using System.Collections.Generic;

namespace Integral.Collections
{
    public class DelegatedKeyedCollection<Key, Element> : VirtualKeyedCollection<Key, Element>, ObservableCollection<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        public DelegatedKeyedCollection(KeyedCollection<Key, Element> keyedCollection) : base(keyedCollection)
        {
        }

        public event Action<Key, Element>? OnAdd;

        public event Action<Key, Element>? OnRemove;

        public override bool Add(Key key, Element element)
        {
            bool success = base.Add(key, element);
            OnAdd?.Invoke(key, element);
            return success;
        }

        public override bool Remove(Key key, out Element element)
        {
            bool success = Peek(key, out element);
            OnRemove?.Invoke(key, element);
            return success;
        }

        public override void Clear()
        {
            foreach (KeyValuePair<Key, Element> keyValuePair in this)
            {
                OnRemove?.Invoke(keyValuePair.Key, keyValuePair.Value);
            }

            base.Clear();
        }
    }
}