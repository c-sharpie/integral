using System.Threading;
using System.Threading.Tasks;

namespace Integral.Actions
{
    public delegate ValueTask AsyncValueAction(CancellationToken cancellationToken);

    public delegate ValueTask AsyncValueAction<in Argument>(Argument argument, CancellationToken cancellationToken);
}