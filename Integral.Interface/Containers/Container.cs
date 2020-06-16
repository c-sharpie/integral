namespace Integral.Containers
{
    public interface Container<in Value>
        where Value : notnull
    {
        bool Contains(Value value);
    }
}