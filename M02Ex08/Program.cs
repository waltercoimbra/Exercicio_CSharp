using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= PAR OU IMPAR ===========");
            Console.WriteLine("");
            int num;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num);

            string tipo = (num % 2 == 0) ? "PAR" : "IMPAR";
            Console.WriteLine($"O número {num} é {tipo}");
            Console.ReadKey();
        }
    }
}
