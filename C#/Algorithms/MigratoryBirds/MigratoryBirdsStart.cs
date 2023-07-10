using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MigratoryBirds
{
    public static class MigratoryBirdsStart
    {
        public static void Start()
        {
            var birdSpecies = new List<int>() { 1, 2, 3, 4, 5, 5, 4};
            if(MigratoryBirdsService.Validate(birdSpecies))
                Console.WriteLine(MigratoryBirdsService.Start(birdSpecies));
        }
    }
}
