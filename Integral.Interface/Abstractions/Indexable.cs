namespace Integral.Abstractions
{
    public interface Indexable<in Key, Element>
        where Key : notnull
        where Element : notnull
    {
        Element this[Key key] { get; set; }
    }
}