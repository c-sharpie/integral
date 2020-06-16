using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Readable<in Data>
        where Data : notnull
    {
        ValueTask Read(Data data, CancellationToken cancellationToken);
    }
}