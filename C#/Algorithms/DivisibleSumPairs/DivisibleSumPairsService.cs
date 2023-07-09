namespace Algorithms.DivisibleSumPairs
{
    public static class DivisibleSumPairsService
    {
        public static int Start(int arrayCount, int divisor, List<int> array)
        {
            var divisonResult = 0;
            for(var i = 0; i < array.Count -1; i++)
            {
                for(var j = i+1; j < array.Count; j++)
                {
                    var sumResult = array[i] + array[j];
                    if (sumResult % divisor == 0)
                        divisonResult++;
                }
            }
            return divisonResult;
        }

        public static bool Validate(int arrayCount, int divisor, List<int> array)
        {
            if ((arrayCount < 2 || arrayCount > 100) ||
                (divisor < 1 || divisor > 100)) 
                    return false;

            foreach (var number in array)
            {
                if (number < 1 || number > 100) return false;
            }
            return true;
        }
    }
}
