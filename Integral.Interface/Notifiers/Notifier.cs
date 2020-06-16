using System;

namespace Integral.Notifiers
{
    public interface Notifier
    {
        event Action OnNotify;
    }
}