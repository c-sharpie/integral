using System;

namespace Integral.Collections
{
    public interface ObservableCollection<out Element>
        where Element : notnull
    {
        event Action<Element> OnAdd;

        event Action<Element> OnRemove;
    }

    public interface ObservableCollection<out Key, out Element>
        where Key : notnull
        where Element : notnull
    {
        event Action<Key, Element> OnAdd;

        event Action<Key, Element> OnRemove;
    }
}