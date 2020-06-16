using System.Threading;
using System.Threading.Tasks;

namespace Integral.Functions
{
    public delegate Task<Result> AsyncFunction<Result>(CancellationToken cancellationToken);

    public delegate Task<Result> AsyncFunction<in Argument, Result>(Argument argument, CancellationToken cancellationToken);
}