namespace mmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = "sv1a6dbNJ5S2KDS53nda4nkd5s7S,D";

            int count = content.Count(c => c == '5');

            Console.WriteLine(count);
        }
    }
}
