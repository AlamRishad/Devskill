using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine(name);
        }

        public static string GetName()
        {
            var a = GetObject();
            String s = Convert.ToString((a));
            string p = s.Substring(s.IndexOf("= ")+1, s.IndexOf(", ")-1);
            string d = p.Substring(p.IndexOf(" ")+1, p.IndexOf(",")-1);
            return d;

        }

        public static object GetObject()
        {
            return new { Name = "Camera", Price = 200 };
        }
    }
}
