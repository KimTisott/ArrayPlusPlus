using System;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static T[] Take<T>(this T[] array, int count)
        {
            Array.Resize(ref array, count);

            return array;
        }
    }
}