namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static bool ContainsPP<T>(this T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsPP<T>(this T[] array, T element, out int index)
        {
            index = -1;

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