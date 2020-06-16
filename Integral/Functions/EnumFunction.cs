using System;

namespace Integral.Functions
{
    public static class EnumFunction
    {
        public static Enumeration[] GetValues<Enumeration>()
            where Enumeration : Enum => (Enumeration[])Enum.GetValues(typeof(Enumeration));
    }
}
