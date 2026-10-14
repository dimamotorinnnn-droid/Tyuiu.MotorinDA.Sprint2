using Tyuiu.MotorinDA.Sprint2.Task4.V26.Lib;
namespace Tyuiu.MotorinDA.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 10918.959;
            Assert.AreEqual(wait, res);
        }

        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 1030423661936416.5;
            Assert.AreEqual(wait, res);
        }
    }
}
