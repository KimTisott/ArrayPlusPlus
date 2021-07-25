using System;
using System.Collections.Generic;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public unsafe static T[] DistinctPP<T>(this T[] array) where T : unmanaged
        {
            T[] result = array;

            var unique = new HashSet<T>();

            int resultSize = default;

            var length = result.Length;

            if (length > 0)
            {
                fixed (T* pointer = &result[0])
                {
                    for (var i = 0; i < length; i++)
                    {
                        var element = pointer[i];

                        if (!unique.Contains(element))
                        {
                            unique.Add(element);

                            pointer[resultSize++] = element;
                        }
                    }
                }

                Array.Resize(ref result, resultSize);
            }

            return result;
        }
    }
}