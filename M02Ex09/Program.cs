using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine($"O número {n} corresponde a [ {Convert.ToString(n,toBase:2)} ] em BINÁRIO.");
            Console.WriteLine($"O número {n} corresponde a [ {Convert.ToString(n,toBase:8)} ] em OCTAL.");
            Console.WriteLine($"O número {n} corresponde a [ {Convert.ToString(n,toBase:16)} ] em HEXADECIMAL");
            Console.ReadKey();



        }
    }
}
