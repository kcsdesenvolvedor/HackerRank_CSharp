namespace Algorithms.BreakingTheRecords
{
    public static class BreakingTheRecordsStart
    {
        public static void Start()
        {
            var scores = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            if (BreakingTheRecordsService.Validate(scores))
            {
                var records = BreakingTheRecordsService.Start(scores);
                Console.WriteLine(string.Join(",", records));
            }
        }
    }
}
