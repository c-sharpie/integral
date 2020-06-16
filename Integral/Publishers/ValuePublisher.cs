using System;

namespace Integral.Publishers
{
    public class ValuePublisher<Publishable> : Publisher<Publishable>
        where Publishable : struct
    {
        private Publishable publishable;

        public ValuePublisher(Publishable publishable = default) => this.publishable = publishable;

        public Publishable Value
        {
            get => publishable;
            set
            {
                if (!publishable.Equals(value))
                {
                    OnPublish?.Invoke(value);
                    publishable = value;
                }
            }
        }

        public event Action<Publishable>? OnPublish;

        public override string ToString() => publishable.ToString() ?? string.Empty;
    }
}