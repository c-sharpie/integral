namespace Integral.Aggregates
{
    public interface DirectDecreasingAggregate
    {
        bool Remove<Element>(Element element)
            where Element : notnull;
    }

    public interface DirectDecreasingAggregate<in Element>
        where Element : notnull
    {
        bool Remove(Element element);
    }
}