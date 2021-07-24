using System.Collections.Generic;
using System.Linq;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static T[] Distinct<T>(this T[] array)
        {
            var unique = new HashSet<T>();

            for (int i = 0; i < array.Length; i++)
            {
                unique.Add(array[i]);
            }

            return unique.ToArray();
        }
    }
}