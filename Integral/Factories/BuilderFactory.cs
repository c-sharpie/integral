using System;
using Integral.Builders;
using Integral.Collections;

namespace Integral.Factories
{
    public sealed class BuilderFactory<Assembly, Assembler> : ListedCollection<Action<Assembler>>, Factory<Assembly>
        where Assembly : notnull
        where Assembler : notnull
    {
        private readonly Builder<Assembly, Assembler> builder;

        public BuilderFactory(Builder<Assembly, Assembler> builder) => this.builder = builder;

        public Assembly Create() => builder.Build(Build);

        private void Build(Assembler assembler)
        {
            foreach (Action<Assembler> action in this)
            {
                action(assembler);
            }
        }
    }
}