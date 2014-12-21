using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111", "Shawon");
            aHashtable.Add("112", "Rumel");
            aHashtable.Add("113", "Atik");
            string name = (string) aHashtable["111"];
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
