namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int Max(this int[] array, out int? index)
        {
            int max = int.MinValue;

            index = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    index = i;

                    max = array[i];
                }
            }

            return max;
        }
    }
}