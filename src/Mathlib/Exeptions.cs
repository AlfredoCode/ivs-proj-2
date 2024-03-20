/// <summary>
/// Exceptions.cs
/// 
/// Dominik Hofman (xhofma11)
/// Jana Veronika Moskvová (xmoskv01)
/// Tomas Skypala (xskypa03)
/// Erik Žák (xzaker00)
///
/// Implementation of exeptions for Mathlib.version 0.1
/// Last update 2024-03-16
/// <summary>

namespace exeptions
{
    public class DivZeroException : Exception
    {
        public DivZeroException(string message) : base(message)
        {
        }
    }
    public class PowNaturalException : Exception
    {
        public PowNaturalException(string message) : base(message)
        {
        }
    }
    public class SqrtNaturalExeption : Exception
    {
        public SqrtNaturalExeption(string message) : base(message)
        {
        }
    }
    public class SqrtNegExeption : Exception
    {
        public SqrtNegExeption(string message) : base(message)
        {
        }
    }
    public class SqrtbyZeroExeption : Exception
    {
        public SqrtbyZeroExeption(string message) : base(message)
        {
        }
    }
    public class FactorialExeption : Exception
    {
        public FactorialExeption(string message) : base(message)
        {
        }
    }

}