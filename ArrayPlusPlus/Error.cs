using System;

namespace ArrayPlusPlus
{
    internal static class Error
    {
        internal static Exception NoElements()
        {
            return new InvalidOperationException("Array contains no elements");
        }
    }
}