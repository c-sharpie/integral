using System.Threading.Tasks;

namespace Integral.Constructors
{
    public static class ValueTaskConstructor
    {
        public static ValueTask Create() => new ValueTask(Task.CompletedTask);
    }
}
