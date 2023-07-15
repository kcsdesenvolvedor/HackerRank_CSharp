using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BetweenTwoSets
{
    public static class BetweenTwoSetsStart
    {
        public static void Start()
        {
            var firstArray = new List<int>() { 2, 4 };
            var secundArray = new List<int>() { 16, 32, 96 };
            if (BetweenTwoSetsService.Validate(firstArray) && BetweenTwoSetsService.Validate(secundArray))
                Console.WriteLine(BetweenTwoSetsService.Start(firstArray, secundArray));
        }
    }
}
