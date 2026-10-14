using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MotorinDA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28, 
                _ => throw new ArgumentException("Некорректный номер месяца")
            };
      
            int nextN = (n == daysInMonth) ? 1 : n + 1;
            int nextM = (n == daysInMonth) ? m + 1 : m;

            return $"{nextN:D2}.{nextM:D2}";
        }
    }
}
