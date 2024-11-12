using System;
using Tyuiu.SimonovMA.Sprint5.Task0.V8.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void testics()
        {
            string path = Path.Combine("C:", "Users", "user", "Appdata", "Local", "Temp", "OutPutFileTask0.txt");
            
            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            
            Assert.AreEqual(true, fileExists);
        }
    }
}