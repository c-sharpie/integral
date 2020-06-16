using System.Threading;
using System.Threading.Tasks;

namespace Integral.Streams
{
    public interface WriteStream<in Data, out Result>
        where Data : notnull
        where Result : notnull
    {
        bool CanWrite { get; }

        Result WriteAsync(Data data, CancellationToken cancellationToken);

        Task FlushAsync(CancellationToken cancellationToken);
    }
}