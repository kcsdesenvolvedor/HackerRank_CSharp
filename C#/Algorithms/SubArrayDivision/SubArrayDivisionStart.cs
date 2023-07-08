namespace Algorithms.SubArrayDivision
{
    public static class SubArrayDivisionStart
    {
        public static void Start()
        {
            var chocolateSquaresNumbers = new List<int>() { 1, 2, 1, 3, 2 };
            if(SubArrayDivisionService.Validade(chocolateSquaresNumbers, 3, 2))
                Console.WriteLine(SubArrayDivisionService.Start(chocolateSquaresNumbers, 3, 2));
        }
    }
}
