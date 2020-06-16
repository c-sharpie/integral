using System;
using Integral.Factories;

namespace Integral.Builders
{
    public abstract class FactoryBuilder<Assembly, Assembler> : Builder<Factory<Assembly>, Assembler>
        where Assembly : notnull
        where Assembler : notnull
    {
        public Factory<Assembly> Build(Action<Assembler> action)
        {
            Assembly Create() => Assemble(action);
            return new DelegateFactory<Assembly>(Create);
        }

        protected abstract Assembly Assemble(Action<Assembler> action);
    }
}