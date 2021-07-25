namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int MinPP(this int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int MinPP(this int[] array, out int index)
        {
            int min = int.MaxValue;

            index = -1;

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