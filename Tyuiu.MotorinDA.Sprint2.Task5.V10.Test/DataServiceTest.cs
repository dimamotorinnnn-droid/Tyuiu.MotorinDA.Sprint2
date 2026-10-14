using Tyuiu.MotorinDA.Sprint2.Task5.V10.Lib;
namespace Tyuiu.MotorinDA.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(2023, 1, 1));
            Assert.AreEqual("31.01.2023", ds.FindDateOfPreviousDay(2023, 2, 1));
            Assert.AreEqual("28.02.2023", ds.FindDateOfPreviousDay(2023, 3, 1));
            Assert.AreEqual("31.03.2023", ds.FindDateOfPreviousDay(2023, 4, 1));
            Assert.AreEqual("30.04.2023", ds.FindDateOfPreviousDay(2023, 5, 1));
            Assert.AreEqual("31.05.2023", ds.FindDateOfPreviousDay(2023, 6, 1));
            Assert.AreEqual("30.06.2023", ds.FindDateOfPreviousDay(2023, 7, 1));
            Assert.AreEqual("31.07.2023", ds.FindDateOfPreviousDay(2023, 8, 1));
            Assert.AreEqual("31.08.2023", ds.FindDateOfPreviousDay(2023, 9, 1));
            Assert.AreEqual("30.09.2023", ds.FindDateOfPreviousDay(2023, 10, 1));
            Assert.AreEqual("31.10.2023", ds.FindDateOfPreviousDay(2023, 11, 1));
            Assert.AreEqual("30.11.2023", ds.FindDateOfPreviousDay(2023, 12, 1));
        }
    }
}
