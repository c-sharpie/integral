namespace Integral.Abstractions
{
    public interface Peekable
    {
        bool Peek<Element>(out Element element);
    }

    public interface Peekable<Element>
    {
        bool Peek(out Element element);
    }

    public interface Peekable<Key, Element>
        where Key : notnull
    {
        bool Peek(Key key, out Element element);
    }
}