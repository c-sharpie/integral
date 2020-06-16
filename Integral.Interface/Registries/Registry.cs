namespace Integral.Registries
{
    public interface Registry<in Registrant>
        where Registrant : notnull
    {
        void Register(Registrant registrant);

        void Unregister(Registrant registrant);
    }

    public interface Registry<in Registrant, in Registrar>
        where Registrant : notnull
        where Registrar : notnull
    {
        void Register(Registrant registrant, Registrar registrar);

        void Unregister(Registrant registrant, Registrar registrar);
    }
}