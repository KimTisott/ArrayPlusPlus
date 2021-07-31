using System.Collections.Generic;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
            int result = 0;

            var collection = source as ICollection<TSource>;

            if (source != null)
            {
                result = collection.Count;
            }
            else
            {
                using (var enumerator = source.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        result++;
                    }
                }
            }
                
            return result;
        }
    }
}