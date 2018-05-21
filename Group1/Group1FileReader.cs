using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQTask
{
    class FileReader
    {
        public static void DoGroup1(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException("No file with this name: " + fileName);
                }

                List<string[]> readedLines = new List<string[]>();
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        readedLines.Add(line.Split(' '));
                    }
                }

                FileReader.Group1Options(readedLines);
            }
            catch(FileNotFoundException error)
            {
                Console.WriteLine(error);
                Console.WriteLine(error.Message);
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        protected static void Group1Options(List<string[]> task)
        {
            if(task==null)
            {
                return;
            }
            using (StreamWriter result = new StreamWriter("Group1result.txt"))
            { 
                foreach (var data in task)
                {
                    IEnumerable<string> res;

                    switch (data[0])
                    {
                        case "Task#1":
                            res = Group1.Task1(data.Skip(1));
                            result.WriteLine("Task#1");
                            break;
                        case "Task#2":
                            res = Group1.Task2(data.Skip(1));
                            result.WriteLine("Task#2");
                            break;
                        case "Task#3":
                            res = Group1.Task3(data.Skip(1));
                            result.WriteLine("Task#3");
                            break;
                        case "Task#4":
                            res = Group1.Task4(data.Skip(1));
                            result.WriteLine("Task#4");
                            break;
                        case "Task#5":
                            res = Group1.Task5(data.Skip(1));
                            result.WriteLine("Task#5");
                            break;
                        default:
                            res = null;
                            break;
                    }

                    if (res != null)
                    {
                        foreach (var number in res)
                        {
                            result.Write(number + " ");
                        }
                        result.WriteLine();
                    }
                }
            }
        }
    }


}
