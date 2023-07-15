namespace Algorithms.BreakingTheRecords
{
    public static class BreakingTheRecordsService
    {
        public static List<int> Start(List<int> scores)
        {
            var maximumPointIndex = new List<int>();
            var minimumPointIndex = new List<int>();
            var maximumPoint = scores[0];
            var minimumPoint = scores[0];

            for (var i = 0; i < scores.Count; i++){
                if (scores[i] > maximumPoint)
                {
                    maximumPoint = scores[i];
                    maximumPointIndex.Add(i);
                }
                if (scores[i] < minimumPoint)
                {
                    minimumPoint = scores[i];
                    minimumPointIndex.Add(i);
                }
            }

            return new List<int> { maximumPointIndex.Count, minimumPointIndex.Count };
        }

        //Metodo criado para validar as Constraints do HackerRank
        public static bool Validate(List<int> scores)
        {
            if(scores.Count > 1000) return false;
            foreach (var number in scores)
            {
                if (number < 0 || number > Math.Pow(10,8))
                    return false;
            }
            return true;
        }
    }
}
