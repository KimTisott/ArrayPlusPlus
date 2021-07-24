namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static int Average(this int[] array)
        {
            if (array.Length == 0)
            {
                throw Error.NoElements();
            }

            return array.Sum() / array.Length;
        }
    }
}