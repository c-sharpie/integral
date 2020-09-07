namespace Integral.Abstractions
{
    public interface Indexable<in Key, out Element>
        where Key : notnull
        where Element : notnull
    {
        Element this[Key key] { get; }
    }
}