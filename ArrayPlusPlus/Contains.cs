namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static bool Contains<T>(this T[] array, T element, out int? index)
        {
            index = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                {
                    index = i;

                    return true;
                }
            }

            return false;
        }
    }
}