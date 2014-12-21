using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> aDictionary = new Dictionary<int, string>();
            aDictionary.Add(111, "Shawon");
            aDictionary.Add(112, "Rumel");
            aDictionary.Add(113, "Atik");
            string name = aDictionary[111];
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
