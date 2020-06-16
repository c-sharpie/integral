namespace Integral.Consumers
{
    public abstract class VirtualConsumer<Consumable> : Consumer<Consumable>
        where Consumable : notnull
    {
        private readonly Consumer<Consumable> consumer;

        protected VirtualConsumer(Consumer<Consumable> consumer) => this.consumer = consumer;

        public virtual void Consume(Consumable consumable) => consumer.Consume(consumable);
    }
}