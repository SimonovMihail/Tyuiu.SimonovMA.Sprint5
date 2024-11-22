using Tyuiu.SimonovMA.Sprint5.Task7.V26.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FINAL_RESPONSE()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V26.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}