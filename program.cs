using System;
using NLog.Web;
using System.IO;

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\nlog.config";
            var logger = NLog.Web.NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();

            logger.Info("Program started");
            var file = "movies.csv";

            Console.WriteLine("Enter 1 to see movie data");
            Console.WriteLine("Enter 2 to add to movie data");
            Console.WriteLine("Enter anything else to quit");

            string response = Console.ReadLine();

            if (response == "1"){
            Console.WriteLine("What movie data do you want to access?");
            string acc = Console.ReadLine();

             try
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);

                IEnumerable<FileInfo> filelist = dir.GetFiles(fileExtension, SearchOption.AllDirectories)
                    .Where(file => file.LastWriteTime.ToString("yyyy-MM-dd")==searchDate);

                var foundFilesCtr = 0;
                Console.WriteLine($"Searching for {searchText} in {response}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Search results...");
                Console.WriteLine($"Found {filelist.Count()} files with extenstion {fileExtension}");
                foreach (var item in filelist)
                    if (File.ReadAllLines(item.FullName).Contains(searchText))
                    {
                        Console.WriteLine($"File with selected content:{item.FullName}");
                        foundFilesCtr++;
                    }
                Console.WriteLine($"Found {foundFilesCtr} files with text {response}");
                Console.WriteLine("------------------------------------");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            Console.ReadKey();
        }
            }

            else if (response == "2"){
             Console.WriteLine("What movie data do you want to add onto?");  
             string add = Console.ReadLine();

              if (File.Exists(file))
                {
                    StreamReader sr = new StreamReader(file);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string [] movieId = line.Split(',');
                        string [] title = line.Split(',');
                        string [] genres = line.Split(',');

             void DirSearch(string sDir, string SEARCH_WORDS, int row)
                {
                int i;
                i = 0;

                try
                {
                foreach (var d in Directory.GetDirectories(response))
                {
                DirectoryInfo di = new DirectoryInfo(d);
                if ((di.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint) {
                    continue;
                }
                try
                {
                    foreach (string file in Directory.GetFiles(d, SEARCH_WORDS, SearchOption.AllDirectories))
                    {
                        Console.WriteLine(file);
                        using (StreamWriter sw = File.AppendText(FILE_NAME))
                        {
                            sw.WriteLine(file);
                            sw.Close();
                            i++;
                        }
                    }
                } 
            }

            else{
                logger.Warn("File does not exists. {file}", file);
                }
            }
            logger.Info("Program ended");
        }
    }
}
