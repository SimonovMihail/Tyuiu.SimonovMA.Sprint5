using Tyuiu.SimonovMA.Sprint5.Task6.V26.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void If_EXISTS()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V26.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }

        [TestMethod]
        public void if_counts_right()
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V26.txt");

            int count = ds.LoadFromDataFile(path);

            Assert.AreEqual(6, count);
        }


    }
}