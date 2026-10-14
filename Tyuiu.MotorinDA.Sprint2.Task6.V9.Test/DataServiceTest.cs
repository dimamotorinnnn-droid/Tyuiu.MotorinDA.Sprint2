using Newtonsoft.Json.Linq;
using Tyuiu.MotorinDA.Sprint2.Task6.V9.Lib;
namespace Tyuiu.MotorinDA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

 
            Assert.AreEqual("2.3", ds.FindDateOfNextDay(3, 1));


            Assert.AreEqual("1.5", ds.FindDateOfNextDay(4, 30));


            Assert.AreEqual("1.8", ds.FindDateOfNextDay(7, 31));

    
            Assert.AreEqual("1.3", ds.FindDateOfNextDay(2, 28));
        }

    
    }
}
