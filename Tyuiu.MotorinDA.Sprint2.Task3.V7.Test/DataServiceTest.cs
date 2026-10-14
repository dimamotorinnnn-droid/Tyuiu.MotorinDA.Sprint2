using Tyuiu.MotorinDA.Sprint2.Task3.V7.Lib;
namespace Tyuiu.MotorinDA.Sprint2.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 375;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 64;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            double x = -12;
            double res = ds.Calculate(x);
            double wait = 20736.25;
            Assert.AreEqual(wait, res);
        }
    }
}
