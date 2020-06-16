using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Flushable
    {
        Task Flush(CancellationToken cancellationToken);
    }
}