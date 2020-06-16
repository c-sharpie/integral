using System.Threading;
using System.Threading.Tasks;

namespace Integral.Abstractions
{
    public interface Initializable
    {
        void Initialize();
    }

    public interface Initializable<Return>
        where Return : Task
    {
        Return Initialize(CancellationToken cancellationToken);
    }
}