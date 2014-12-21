﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue= new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(150);
            Console.WriteLine(aQueue.Dequeue());
            Console.WriteLine(aQueue.Dequeue());
            Console.WriteLine(aQueue.Dequeue());
            Console.ReadKey();
        }
    }
}
