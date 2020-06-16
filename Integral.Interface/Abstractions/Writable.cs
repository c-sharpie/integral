using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Writable<in Data>
        where Data : notnull
    {
        ValueTask Write(Data data, CancellationToken cancellationToken);
    }
}