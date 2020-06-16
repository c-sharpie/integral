using System;

namespace Integral.Notifiers
{
    public class GenericNotifier : Notifier
    {
        public event Action? OnNotify;

        public void Notify() => OnNotify?.Invoke();
    }
}
