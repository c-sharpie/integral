namespace Integral.Subscribers
{
    public interface Subscriber<in Subscribable>
        where Subscribable : notnull
    {
        void OnPublished(Subscribable subscribable);
    }
}