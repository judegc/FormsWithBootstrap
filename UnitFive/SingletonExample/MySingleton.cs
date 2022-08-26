using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class MySingleton
    {
        private static readonly MySingleton _instance = new MySingleton();

        public List<string> MyData = new List<string>();

        public static MySingleton GetInstance()
        {
            return _instance;
        }

        public void PrintData()
        {
            MyData.ForEach(x => Console.WriteLine(x));
        }
    }
}
