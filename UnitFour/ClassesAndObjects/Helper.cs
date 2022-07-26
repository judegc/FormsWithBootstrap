using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public static class Helper
    {
        public static void PrintTwoStrings(string a, string b)
        {
            Console.WriteLine(String.Format("{0, -15} {1, -15}", a, b));
        }
    }
}
