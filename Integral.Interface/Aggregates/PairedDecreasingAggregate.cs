namespace Integral.Aggregates
{
    public interface PairedDecreasingAggregate
    {
        bool Remove<Key, Element>(Key key, out Element element)
            where Key : notnull
            where Element : notnull;
    }

    public interface PairedDecreasingAggregate<in Key, Element>
        where Key : notnull
        where Element : notnull
    {
        bool Remove(Key key, out Element element);
    }
}