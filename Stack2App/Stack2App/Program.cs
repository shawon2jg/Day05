using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack = new Stack<int>();
            //aStack.Push(100);
            //aStack.Push(200);
            //aStack.Push(300);
            for (int i = 0; i < 10; i++)
            {
                aStack.Push(i);
            }
            foreach (int anItems in aStack)
            {
                Console.WriteLine(anItems);
            }
            Console.ReadKey();
        }
    }
}
