using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.Write("Digite um número Real: ");
            float.TryParse(Console.ReadLine(), out num);
            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Você digitou o valor {num:N1}");
            Console.WriteLine($"A parte inteira do número é {n1:D}");
            Console.WriteLine($"Arredondando, temos o número {n2:D}");
            Console.ReadKey();
            
        }
    }
}
