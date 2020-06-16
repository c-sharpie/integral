using System;

namespace Integral.Publishers
{
    public class GenericPublisher<Publishable> : Publisher<Publishable>
        where Publishable : notnull
    {
        public event Action<Publishable>? OnPublish;

        public bool IsSubscribed => OnPublish?.GetInvocationList()?.Length > 0;

        public void Publish(Publishable publishable) => OnPublish?.Invoke(publishable);
    }
}