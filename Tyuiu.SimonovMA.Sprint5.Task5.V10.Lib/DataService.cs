using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SimonovMA.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            string[] numbers;

            if (File.ReadAllText(path).Count(f => f == ' ') >= 1)
            {
                numbers = File.ReadAllText(path).Replace('.', ',').Split(' ');
            }
            else
            {
                numbers = File.ReadAllText(path).Replace('.', ',').Split('\n');
            }

            double sum = 0;

            foreach (string number in numbers)
            {
                double double_number = Convert.ToDouble(number);
                if ((double_number % 2 == 0) && (double_number % 1 == 0))
                {
                    sum = sum + double_number;
                }
            }

            return sum;
        }
    }
}
