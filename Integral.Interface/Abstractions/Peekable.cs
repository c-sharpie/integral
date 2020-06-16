namespace Integral.Abstractions
{
    public interface Peekable
    {
        bool Peek<Element>(out Element element)
            where Element : notnull;
    }

    public interface Peekable<Element>
        where Element : notnull
    {
        bool Peek(out Element element);
    }

    public interface Peekable<Key, Element>
        where Key : notnull
        where Element : notnull
    {
        bool Peek(Key key, out Element element);
    }
}