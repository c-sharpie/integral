namespace Integral.Factories
{
    public interface Factory<out Creation>
        where Creation : notnull
    {
        Creation Create();
    }
}