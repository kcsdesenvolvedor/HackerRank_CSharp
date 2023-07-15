namespace Algorithms.DayOfTheProgrammer
{
    public static class DayOfTheProgrammerService
    {
        public static string Start(int year)
        {
            // verificar o tipo do calendario 
            var caledarType = GetCalendarType(year);
            // verificar se é ano bissexto
            var isYearLeap = VerifyIfLeapYear(year, caledarType);
            // calcular qual o 256 dia do ano
            var programmerDay = GetProgrammerDay(isYearLeap, year);
            return programmerDay;
        }

        //Metodo criado para validar as Constraints do HackerRank
        public static bool Validade(int year)
        {
            if (year < 1700 || year > 2700) return false;
            return true;
        }

        private static string GetProgrammerDay(bool isYearLeap, int year)
        {
            return !isYearLeap && year == 1918 ? $"26.09.{year}" : isYearLeap ? $"12.09.{year}" : $"13.09.{year}";
        }

        private static bool VerifyIfLeapYear(int year, CalendarType calendarType)
        {
            if(calendarType == CalendarType.Julian)
            {
                return year % 4 == 0;
            }
            else
            {
                if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    return true;
                }
                return false;
            }
        }

        private static CalendarType GetCalendarType(int year)
        {
            return year < 1918 ? CalendarType.Julian : CalendarType.Gregorian;
        }
    }

    public enum CalendarType
    {
        Julian = 0,
        Gregorian = 1,
    }
}
