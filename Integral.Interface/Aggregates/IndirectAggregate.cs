namespace Integral.Aggregates
{
    public interface IndirectAggregate : IndirectIncreasingAggregate, IndirectDecreasingAggregate
    {
    }

    public interface IndirectAggregate<Element> : IndirectIncreasingAggregate<Element>, IndirectDecreasingAggregate<Element>
        where Element : notnull
    {
    }
}