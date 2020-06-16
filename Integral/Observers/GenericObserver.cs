using System;

namespace Integral.Observers
{
    public class GenericObserver<Observable> : Observer<Observable>
        where Observable : notnull
    {
        public event Action<Observable, Observable>? OnChange;

        public bool IsSubscribed => OnChange?.GetInvocationList()?.Length > 0;

        public void Change(Observable previous, Observable current) => OnChange?.Invoke(previous, current);
    }
}