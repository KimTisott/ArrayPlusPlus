namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int SumPP(this int[] array)
        {
            int sum = default;

            checked
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}