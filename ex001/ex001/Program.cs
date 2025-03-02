using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 4);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" MEU ");
            Console.ResetColor();
            Thread.Sleep(600);
            
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  BRASIL ");
            Console.ResetColor();
            Thread.Sleep(600);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  BRASILEIRO ");
            Console.ResetColor();
            Thread.Sleep(600);

            Console.ReadKey();
        }
    }
}
