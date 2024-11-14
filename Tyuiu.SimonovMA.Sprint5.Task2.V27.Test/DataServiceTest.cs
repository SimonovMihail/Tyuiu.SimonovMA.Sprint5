using System;
using Tyuiu.SimonovMA.Sprint5.Task2.V27.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "Users", "user", "Appdata", "Local", "Temp", "OutPutFileTask2.csv");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}