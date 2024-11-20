using Tyuiu.SimonovMA.Sprint5.Task4.V9.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V9.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}