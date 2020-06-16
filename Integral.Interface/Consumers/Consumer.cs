namespace Integral.Consumers
{
    public interface Consumer<in Consumable>
        where Consumable : notnull
    {
        void Consume(Consumable consumable);
    }
}