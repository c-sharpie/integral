using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Executable
    {
        void Execute();
    }

    public interface Executable<Return>
        where Return : Task
    {
        Return Execute(CancellationToken cancellationToken);
    }
}