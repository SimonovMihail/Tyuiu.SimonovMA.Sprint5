using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SimonovMA.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string output_path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V26.txt");

            FileInfo fileInfo = new FileInfo(output_path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(output_path);
            }

            string pattern = @"\b[A-Za-z]+\b";
            string updated_content = Regex.Replace(content, pattern, "word");

            File.WriteAllText(output_path, updated_content);

            return output_path;
        }
    }
}
