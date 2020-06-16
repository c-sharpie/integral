using System;
using Integral.Components;
using Integral.Compositions;

namespace Integral.Builders
{
    public abstract class ComponentBuilder<Assembly, Assembler> : Builder<Assembly, Assembler>
        where Assembly : notnull, Component
        where Assembler : notnull
    {
        public Composition? Composition { get; set; }

        public abstract Assembly Build(Action<Assembler> action);
    }
}