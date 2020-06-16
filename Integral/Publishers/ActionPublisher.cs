using System;

namespace Integral.Publishers
{
    public abstract class ActionPublisher<Publishable> : GenericPublisher<Action<Publishable>>
        where Publishable : notnull
    {
        protected void Publish() => Publish(Publish);

        protected virtual void Publish(Publishable publishable) => throw new NotImplementedException();
    }
}