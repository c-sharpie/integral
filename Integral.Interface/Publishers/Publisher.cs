using System;

namespace Integral.Publishers
{
    public interface Publisher<out Publishable>
        where Publishable : notnull
    {
        event Action<Publishable> OnPublish;
    }
}