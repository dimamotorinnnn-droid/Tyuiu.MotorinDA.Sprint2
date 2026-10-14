using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MotorinDA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool topArea = (y >= 0) && (x >= 0) && (y <= 1) && (y >= x - 1);

            bool bottomArea = (y < 0) && (x >= 0) && (y <= x - 1) && (x * x + y * y <= 1);

            return topArea || bottomArea;
        }
    }
}
