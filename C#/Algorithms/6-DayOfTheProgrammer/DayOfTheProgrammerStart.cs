using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DayOfTheProgrammer
{
    public static class DayOfTheProgrammerStart
    {
        public static void Start()
        {
            int year = 1918;
            if(DayOfTheProgrammerService.Validade(year))
                Console.WriteLine(DayOfTheProgrammerService.Start(year));
        }
    }
}
