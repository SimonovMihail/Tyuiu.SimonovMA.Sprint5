using System;
using Tyuiu.SimonovMA.Sprint5.Task1.V17.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void the_biggest_test_in_da_world()
        {
            string path = Path.Combine("C:", "Users", "user", "Appdata", "Local", "Temp", "OutPutFileTask1.txt");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}