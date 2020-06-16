using System.Threading;

namespace Integral.Streams
{
    public interface ReadStream<in Data, out Result>
        where Data : notnull
        where Result : notnull
    {
        bool CanRead { get; }

        Result ReadAsync(Data data, CancellationToken cancellationToken);
    }
}