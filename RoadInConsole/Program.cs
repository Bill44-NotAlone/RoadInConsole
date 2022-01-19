using System;
using System.Collections.Generic;
using System.Threading;

namespace RoadInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Road road = new Road();
            road.Run();
        }
    }
    public class Road
    {
        Queue<string> queue1 = new Queue<string>(20);
        Queue<string> queue2 = new Queue<string>(20);
        private int lenght = 20;
        public Road()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
        }
        public void Run()
        {
            for (int i = 0; i < 15; i++) queue1.Enqueue("-");
            for (int i = 0; i < 5; i++) queue1.Enqueue("0");
            for (int i = 0; i < 15; i++) queue2.Enqueue("-");
            for (int i = 0; i < 5; i++) queue2.Enqueue("0");
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = lenght; i >= 0; i--)
                {
                    Console.SetCursorPosition(i, 0);
                    string str = queue1.Dequeue();
                    Console.Write(str);
                    queue1.Enqueue(str);
                }

                Console.SetCursorPosition(0, 1);
                for (int i = 0; i < lenght +1; i++)
                {
                    string str = queue2.Dequeue();
                    Console.Write(str);
                    queue2.Enqueue(str);
                }
                Thread.Sleep(100);
            }
        }
    }
}
