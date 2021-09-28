using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = GetLines();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static string[] GetLines()
        {
            string[] line = new string[] { };
            
            string path=@"Tasks\Task3\DemoText.txt";
            if(File.Exists(path))
            {
                line = File.ReadAllLines(path);
                return line;
            }
            return line;
        }
    }
    }

