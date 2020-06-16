namespace Integral.Aggregates
{
    public interface IndirectIncreasingAggregate
    {
        bool Add<Element>(Element element)
            where Element : notnull;
    }

    public interface IndirectIncreasingAggregate<in Element>
        where Element : notnull
    {
        bool Add(Element element);
    }
}