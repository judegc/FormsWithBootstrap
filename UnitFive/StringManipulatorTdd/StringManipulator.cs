using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulatorTdd
{
    public static class StringManipulator
    {
        public static string ConcatenateTwoStrings(string a, string b)
        {
            return a + b;
        }

        public static string RemoveAllLetterE(string s)
        {
            return s.Replace("e", "", StringComparison.OrdinalIgnoreCase);
        }
    }
}
