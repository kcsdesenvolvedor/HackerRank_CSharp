namespace Algorithms._8_SalesByMatch
{
    public static class SalesByMatchService
    {
        public static int Start(List<int> pairsOfSocks)
        {
            var pairsQuantity = 0;
            IEnumerable<int> repeatedSocks = GetRepeatedSocks(pairsOfSocks);
            foreach (var socks in repeatedSocks)
            {
                var quantity = pairsOfSocks.Where(s => s == socks);
                double pairs = quantity.Count() / 2;
                pairsQuantity += (int)Math.Truncate(pairs);
            }
            return pairsQuantity;
        }

        //Metodo criado para validar as Constraints do HackerRank
        public static bool Validate(int socksQuantity, List<int> pairsOfSocks)
        {
            if (pairsOfSocks.Count < 1 || pairsOfSocks.Count > 100) return false;
            foreach (var number in pairsOfSocks)
            {
                if (number < 1 || number > 100) return false;
            }
            return true;
        }

        private static IEnumerable<int> GetRepeatedSocks(List<int> pairsOfSocks)
        {
            return pairsOfSocks.GroupBy(x => x).Where(s => s.Count() > 1).Select(c => c.Key);
        }
    }
}
