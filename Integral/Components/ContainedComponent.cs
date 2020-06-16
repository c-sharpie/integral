using Integral.Compositions;

namespace Integral.Components
{
    public abstract class ContainedComponent : Component
    {
        //protected ContainedComponent(Composition composition) => Composition = composition;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public Composition Composition { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    }
}
