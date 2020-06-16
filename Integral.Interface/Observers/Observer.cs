using System;

namespace Integral.Observers
{
    public interface Observer<out Observable>
        where Observable : notnull
    {
        event Action<Observable, Observable> OnChange;
    }
}