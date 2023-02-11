using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Activity9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> moveStack = new Stack<string>();
            WriteLine("Loading Stack");
            for (int i = 1; i <= 5; i++)
            {
                moveStack.Push("Move " + i.ToString());
                WriteLine(moveStack.Peek().ToString());
            }

            WriteLine("\nPress the enter key to unload the stack.");
            ReadLine();
            for (int i = 1; i <= 5; i++)
            {
                WriteLine(moveStack.Pop().ToString());
            }

            Queue<string> requestQueue = new Queue<string>();
            WriteLine("Loading Queue");
            for (int i = 1; i <= 5; i++)
            {
                requestQueue.Enqueue("Request " + i.ToString());
                WriteLine(requestQueue.Peek().ToString());
            }

            WriteLine("\nPress the enter key to unload the queue.");
            ReadLine();
            for (int i = 1; i <= 5; i++)
            {
                WriteLine(requestQueue.Dequeue().ToString());
            }

            ReadKey();
        }
    }
}
