namespace Integral.Abstractions
{
    public interface Identifiable<out Key>
        where Key : notnull
    {
        Key Identity { get; }
    }
}