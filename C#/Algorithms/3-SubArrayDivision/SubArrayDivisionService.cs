namespace Algorithms.SubArrayDivision
{
    public static class SubArrayDivisionService
    {
        public static int Start(List<int> chocolateSquareNumbers, int day, int month)
        {
            int segmentsQuantity = 0;
            var count = 0;
            for (var i = month; i <= chocolateSquareNumbers.Count; i++)
            {
                var sumOfSquares = 0;
                for (var j = 0; j < month; j++)
                {
                    sumOfSquares += chocolateSquareNumbers[j + count];
                }
                if (sumOfSquares == day)
                    segmentsQuantity++;

                count++;
            }
            return segmentsQuantity;
        }

        //Metodo criado para validar as Constraints do HackerRank
        public static bool Validade(List<int> chocolateSquareNumbers, int day, int month)
        {
            if ((chocolateSquareNumbers.Count < 1 || chocolateSquareNumbers.Count > 100) ||
                (day < 1 || day > 31) ||
                (month < 1 || month > 31)) 
                    return false;

            foreach (var number in chocolateSquareNumbers)
            {
                if (number < 1 || number > 5) return false;
            }
            return true;
        }
    }
}
