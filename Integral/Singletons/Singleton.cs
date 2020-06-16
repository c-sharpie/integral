namespace Integral.Singletons
{
    public static class Singleton<Newable>
        where Newable : new()
    {
        public static Newable Instance { get; } = new Newable();
    }
}