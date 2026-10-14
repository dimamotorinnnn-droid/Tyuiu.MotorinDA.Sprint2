using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MotorinDA.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevG = g;
            int prevM = m;
            int prevN = n - 1;

            if (n == 1)
            {
                prevM = m - 1;

                if (m == 1)
                {
                    prevM = 12;
                    prevG = g - 1;
                }

                switch (prevM)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        prevN = 31;
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevN = 30;
                        break;

                    case 2:
                        prevN = 28;
                        break;
                }
            }
            return $"{prevN:D2}.{prevM:D2}.{prevG}";
        }
    }
}
