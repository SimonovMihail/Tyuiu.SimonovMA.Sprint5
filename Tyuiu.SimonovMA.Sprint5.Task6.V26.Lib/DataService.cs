using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SimonovMA.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
            return File.ReadAllText(path).Count(f => f == '?');
        }
    }
}
