using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MotorinDA.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 1) && (x <= 14) && (y >= 1) && (y <= 14)) 
            {
                res = true;
            }

            else
            {
                res = false;
            }
            return res;
        }
    }
}
