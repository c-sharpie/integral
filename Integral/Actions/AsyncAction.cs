using System.Threading;
using System.Threading.Tasks;

namespace Integral.Actions
{
    public delegate Task AsyncAction(CancellationToken cancellationToken);

    public delegate Task AsyncAction<in Argument>(Argument argument, CancellationToken cancellationToken);
}