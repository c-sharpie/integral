using System.Threading;

namespace Integral.Abstractions
{
    public interface Executable
    {
        void Execute();
    }

    public interface Executable<out Return>
    {
        Return Execute(CancellationToken cancellationToken);
    }
}