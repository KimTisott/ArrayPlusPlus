namespace ArrayPlusPlus
{
    class Program
    {
        static void Main()
        {
            var array = ArrayPlusPlus.Random(1, 10, 10);

            var distinct = array.Distinct();

            var sum = array.Sum();

            var min = array.Min(out int? minIndex);

            var max = array.Max(out int? maxIndex);

            var contains = array.Contains(array[5], out int? index);

            var skip = array.Skip(5);

            var take = array.Take(3);

            var average = take.Average();
        }
    }
}