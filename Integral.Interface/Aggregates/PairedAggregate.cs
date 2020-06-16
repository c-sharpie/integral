namespace Integral.Aggregates
{
    public interface PairedAggregate : PairedIncreasingAggregate, PairedDecreasingAggregate
    {
    }

    public interface PairedAggregate<in Key, Element> : PairedIncreasingAggregate<Key, Element>, PairedDecreasingAggregate<Key, Element>
        where Key : notnull
        where Element : notnull
    {
    }
}