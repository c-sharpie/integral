namespace Integral.Aggregates
{
    public interface PairedIncreasingAggregate
    {
        bool Add<Key, Element>(Key key, Element element)
            where Key : notnull
            where Element : notnull;
    }

    public interface PairedIncreasingAggregate<in Key, in Element>
        where Key : notnull
        where Element : notnull
    {
        bool Add(Key key, Element element);
    }
}