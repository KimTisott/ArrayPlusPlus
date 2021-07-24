namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int Min(this int[] array, out int? index)
        {
            int min = int.MaxValue;

            index = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    index = i;

                    min = array[i];
                }
            }

            return min;
        }
    }
}