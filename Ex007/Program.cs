using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ SORTEANDO NÚMEROS ----------");

            Console.Write("INÍCIO: ");
            int inicio;
            int.TryParse(Console.ReadLine(), out inicio);

            Console.Write("FIM: ");
            int fim;
            int.TryParse(Console.ReadLine(), out fim);

            Random gerador = new Random();
            int num = gerador.Next(inicio, fim + 1);
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Sorteando.....");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 4);
            Console.WriteLine($"Entre o número {inicio} e {fim} sorteei o número {num}");
            Console.ReadKey();

        }
    }
}
