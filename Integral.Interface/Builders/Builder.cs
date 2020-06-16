using System;

namespace Integral.Builders
{
    public interface Builder<out Assembly, out Assembler>
        where Assembly : notnull
        where Assembler : notnull
    {
        Assembly Build(Action<Assembler> action);
    }
}