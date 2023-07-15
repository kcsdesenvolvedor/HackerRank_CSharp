namespace Algorithms.BillDivision
{
    public static class BillDivisionStart
    {
        public static void Start()
        {
            var consumedFoods = new List<int> { 3, 10, 2, 9 };
            if(BillDivisionService.Validate(consumedFoods, 1, 7))
                Console.WriteLine(BillDivisionService.Start(consumedFoods, 1, 7));
        }
    }
}
