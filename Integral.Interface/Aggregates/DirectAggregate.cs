namespace Integral.Aggregates
{
    public interface DirectAggregate : IndirectIncreasingAggregate, DirectDecreasingAggregate
    {
    }

    public interface DirectAggregate<in Element> : IndirectIncreasingAggregate<Element>, DirectDecreasingAggregate<Element>
        where Element : notnull
    {
    }
}