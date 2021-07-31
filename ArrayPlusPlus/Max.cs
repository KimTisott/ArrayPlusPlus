using System.Collections.Generic;

namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        /// <summary>
        /// Returns the maximum value in an array and outputs its index.
        /// </summary>
        /// <typeparam name="TSource">The type of values in <paramref name="source"/>.</typeparam>
        /// <param name="source">An array of <typeparamref name="TSource"/> values.</param>
        /// <param name="index">The index of the maximum <typeparamref name="TSource"/> value, if found; otherwise, -1.</param>
        /// <returns>The maximum <typeparamref name="TSource"/> value in <paramref name="source"/>.</returns>
        /// <exception cref="System.InvalidOperationException">Array contains no elements</exception>
        public static TSource MaxPP<TSource>(this TSource[] source, out int index)
        {
            var length = source.Length;

            if (length == 0)
            {
                throw Error.NoElements();
            }

            TSource result = default;

            index = -1;

            if (result == null)
            {
                for (var i = 0; i < length; i++)
                {
                    var element = source[i];

                    if (element == null)
                    {
                        continue;
                    }

                    if (Comparer<TSource>.Default.Compare(element, result) > 0)
                    {
                        result = element;

                        index = i;
                    }
                }
            }
            else
            {
                result = source[0];

                for (var i = 1; i < length; i++)
                {
                    var element = source[i];

                    if (Comparer<TSource>.Default.Compare(element, result) > 0)
                    {
                        result = element;

                        index = i;
                    }
                }
            }

            return result;
        }
    }
}