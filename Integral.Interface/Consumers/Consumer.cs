namespace Integral.Consumers
{
    public interface Consumer<in Consumable>
        where Consumable : notnull
    {
        void Consume(Consumable consumable);
    }

    public interface Consumer<in Consumable, out Return>
        where Consumable : notnull
    {
        Return Consume(Consumable consumable);
    }
}