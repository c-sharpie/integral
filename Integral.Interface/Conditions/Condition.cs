using Integral.Abstractions;
using Integral.Publishers;

namespace Integral.Conditions
{
    public interface Condition : Enableable, Publisher<bool>
    {
    }
}