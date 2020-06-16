using Integral.Abstractions;
using Integral.Conditions;

namespace Integral.Commands
{
    public interface Command : Condition, Executable
    {
    }
}