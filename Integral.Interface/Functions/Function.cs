namespace Integral.Functions
{
    public interface Function<in Input, out Output>
        where Input : notnull
        where Output : notnull
    {
        Output Execute(Input input);
    }
}