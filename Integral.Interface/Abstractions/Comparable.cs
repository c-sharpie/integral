using System;

namespace Integral.Abstractions
{
    public interface Comparable<in Term> : IComparable<Term>
    {
    }
}