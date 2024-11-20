using Tyuiu.SimonovMA.Sprint5.Task4.V9.Lib;

namespace Tyuiu.SimonovMA.Sprint5.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение из   *");
            Console.WriteLine("* файла и подставить всето Х в формуле. Вычеслить значение по формуле и   *");
            Console.WriteLine("* вернуть полученный результат на консоль.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Файл по пути C:/DataSprint5/InPutDataFileTask5V9.txt                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V9.txt");
            string strX = File.ReadAllText(path);

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("Ответ: " + result);
            Console.ReadKey();
        }
    }
}
