namespace xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V10.txt");
            string[] numbers = File.ReadAllText(path).Split('\n');
            double sum = 0;
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
