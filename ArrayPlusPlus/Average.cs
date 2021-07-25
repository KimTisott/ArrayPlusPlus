namespace ArrayPlusPlus
{
    public static partial class ArrayPlusPlus
    {
        public static double AveragePP(this int[] array)
        {
            if (array.Length == 0)
            {
                throw Error.NoElements();
            }

            return (double) array.SumPP() / array.Length;
        }
    }
}