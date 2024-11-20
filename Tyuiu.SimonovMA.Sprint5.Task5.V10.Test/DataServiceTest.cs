using Tyuiu.SimonovMA.Sprint5.Task5.V10.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V10.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}