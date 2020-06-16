using System;

namespace Integral.Observers
{
    public class ValueObserver<Observable> : Observer<Observable>
        where Observable : struct
    {
        private Observable observable;

        public ValueObserver(Observable observable = default) => this.observable = observable;

        public Observable Value
        {
            get => observable;
            set
            {
                if (!observable.Equals(value))
                {
                    OnChange?.Invoke(observable, value);
                    observable = value;
                }
            }
        }

        public event Action<Observable, Observable>? OnChange;

        public override string ToString() => observable.ToString() ?? string.Empty;
    }
}