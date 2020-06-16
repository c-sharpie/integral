namespace Integral.Aggregates
{
    public interface IndirectDecreasingAggregate
    {
        bool Remove<Element>(out Element element)
            where Element : notnull;
    }

    public interface IndirectDecreasingAggregate<Element>
        where Element : notnull
    {
        bool Remove(out Element element);
    }
}