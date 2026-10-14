using Tyuiu.MotorinDA.Sprint2.Task5.V10.Lib;
namespace Tyuiu.MotorinDA.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Моторин Д.А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Моторин Дмитрий Алексеевич | ИИПб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение G:");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение M:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение N:");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindDateOfPreviousDay(g,m,n));
        }
    }
}
