namespace Algorithms.DivisibleSumPairs
{
    public static class DivisibleSumPairsStart
    {
        public static void Start()
        {
            var array = new List<int>() { 1, 3, 2, 6, 1, 2 };
            Console.WriteLine(DivisibleSumPairsService.Start(6, 3, array));
        }
    }
}
