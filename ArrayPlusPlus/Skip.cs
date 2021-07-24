using System;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static T[] Skip<T>(this T[] array, int count)
        {
            int newCount = array.Length - count;

            var newArray = new T[newCount];

            Array.Copy(array, count, newArray, 0, newCount);

            return newArray;
        }
    }
}