﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack = new Stack<int>();
            aStack.Push(100);
            aStack.Push(200);
            aStack.Push(300);
            Console.WriteLine(aStack.Pop());
            Console.WriteLine(aStack.Pop());
            Console.WriteLine(aStack.Pop());
            Console.ReadKey();
        }
    }
}
