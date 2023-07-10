namespace Algorithms.MigratoryBirds
{
    public static class MigratoryBirdsService
    {
        public static int Start(List<int> birdSpecies)
        {
            var repeatedSpecies = new Dictionary<int, int>();
            for(var i = 0; i < birdSpecies.Count; i++)
            {
                if (!repeatedSpecies.ContainsKey(birdSpecies[i]))
                {
                    var findNumberSpecie = birdSpecies.Where(s => s == birdSpecies[i]).ToList();
                    repeatedSpecies.Add(birdSpecies[i], findNumberSpecie.Count);
                }
            }
            var repeatedSpeciesOrder = repeatedSpecies.OrderBy(x => x.Value).ToList();
            var dictionaryWithMostSpecies = repeatedSpeciesOrder.Where(x => x.Value == repeatedSpeciesOrder.Last().Value).OrderBy(x => x.Key).ToList();
            
            return dictionaryWithMostSpecies[0].Key;
        }

        //Metodo criado para validar as Constraints do HackerRank
        public static bool Validate(List<int> birdSpecies)
        {
            if (birdSpecies.Count < 5 || birdSpecies.Count > (2 * Math.Pow(10, 5))) return false;
            foreach (var number in birdSpecies)
            {
                if (number < 1 || number > 5) return false;
            }

            return true;
        }
    }
}
