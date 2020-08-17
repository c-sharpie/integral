using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Iterable
    {
        void Iterate();
    }

    public interface Iterable<Return>
        where Return : Task
    {
        Return Iterate(CancellationToken cancellationToken);
    }
}