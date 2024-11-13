namespace _234234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = 10;
            double end = 12;
            double step = 1;
            string output = "";

            for (double x = start; x <= end; x += step)
            {
                double result = 2 * x + 3 * Math.Pow(x, 2) - 94;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                output = output + Convert.ToString(result) + " ";
            }

            Console.WriteLine(output);
        }
    }
}
