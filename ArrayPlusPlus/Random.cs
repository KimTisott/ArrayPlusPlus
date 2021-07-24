using System;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int[] Random(int floor, int ceiling, int count)
        {
            var array = new int[count];

            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(floor, ceiling);
            }

            return array;
        }
    }
}