using System.Threading;
using System.Threading.Tasks;

namespace Integral.Functions
{
    public delegate ValueTask<Result> AsyncValueFunction<Result>(CancellationToken cancellationToken);

    public delegate ValueTask<Result> AsyncValueFunction<in Argument, Result>(Argument argument, CancellationToken cancellationToken);
}