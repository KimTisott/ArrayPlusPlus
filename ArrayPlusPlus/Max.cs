namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int MaxPP(this int[] array, int defaultValue = int.MinValue)
        {
            int max = defaultValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int MaxPP(this int[] array, out int index, int defaultValue = int.MinValue)
        {
            int max = defaultValue;

            index = -1;

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