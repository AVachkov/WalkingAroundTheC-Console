using System;
using System.Collections.Generic;
using System.Threading;

namespace WalkingAroundTheConsole
{
    class Program
    {

        static List<ConsoleColor> colors = new List<ConsoleColor>() { ConsoleColor.Red,
                ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan,
                ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.DarkBlue,
                ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen};
        static Random r = new Random();
        static void Main(string[] args)
        {
            int n = Console.BufferHeight + Console.BufferWidth;
            int j = 0;
            Console.CursorVisible = false;
            WriteHello();
            Console.Clear();
            Thread.Sleep(400);
            WriteStartMsg();
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Clear();
                    if (k != Console.BufferWidth && j != 30)
                    {
                        Console.SetCursorPosition(k, j);
                        Console.ForegroundColor = colors[r.Next(0, 9)];
                        Console.Write('>');
                        Console.ResetColor();
                    }
                    else if (k == Console.BufferWidth)
                    {
                        ReachBufferWidth(k, ++j);
                        k = -1;
                        flag = true;
                    }
                    else if (j == 30)
                        break;

                    if (flag)
                    {
                        j++;
                        flag = false;
                    }
                    Thread.Sleep(1);
                }
            }
            WriteGoodbye();
        }
        static void WriteGoodbye()
        {
            Console.SetCursorPosition(0, Console.BufferHeight - 1);
            Console.Write("G"); Thread.Sleep(200); Console.Write("o"); Thread.Sleep(200);
            Console.Write("o"); Thread.Sleep(200); Console.Write("d"); Thread.Sleep(200);
            Console.Write("b"); Thread.Sleep(200); Console.Write("y"); Thread.Sleep(200);
            Console.Write("e"); Thread.Sleep(200); Console.Write("!"); Thread.Sleep(400);
            Console.WriteLine();
        }
        static void WriteHello()
        {
            Console.Write("H"); Thread.Sleep(200); Console.Write("e"); Thread.Sleep(200);
            Console.Write("l"); Thread.Sleep(200); Console.Write("l"); Thread.Sleep(200);
            Console.Write("o"); Thread.Sleep(200); Console.Write("!"); Thread.Sleep(600);
        }
        static void WriteStartMsg()
        {
            Console.Write("S"); Thread.Sleep(200); Console.Write("t"); Thread.Sleep(200);
            Console.Write("a"); Thread.Sleep(200); Console.Write("r"); Thread.Sleep(200);
            Console.Write("t"); Thread.Sleep(200); Console.Write("i"); Thread.Sleep(200);
            Console.Write("n"); Thread.Sleep(200); Console.Write("g"); Thread.Sleep(200);
            Console.Write(" "); Thread.Sleep(50); Console.Write("i"); Thread.Sleep(200);
            Console.Write("n"); Console.Write(" "); Thread.Sleep(200); Console.Write("3");
            Thread.Sleep(200);
            Console.Write("."); Thread.Sleep(300); Console.Write("."); Thread.Sleep(400);
            Console.Write("."); Thread.Sleep(500); Console.Write("2"); Thread.Sleep(200);
            Console.Write("."); Thread.Sleep(400); Console.Write("."); Thread.Sleep(400);
            Console.Write("."); Thread.Sleep(500); Console.Write("1"); Thread.Sleep(1000);
        }
        static void ReachBufferWidth(int width, int height)
        {
            while (width > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(--width, height);
                Console.ForegroundColor = colors[r.Next(0, 9)];
                Console.Write('<');
                Console.ResetColor();
                Thread.Sleep(1);
            }
        }
    }

}
