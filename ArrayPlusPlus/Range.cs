namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int[] Range(int start, int count, int change = 1)
        {
            var array = new int[count];

            checked
            {
                for (int i = 0; i < count; i++)
                {
                    array[i] = start + i * change;
                }
            }

            return array;
        }
    }
}