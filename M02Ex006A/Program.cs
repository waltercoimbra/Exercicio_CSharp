using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Digite a idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            bool sit01 = idade >= 0 && idade < 16;
            bool sit02 = idade >= 16 && idade < 18 || idade >= 65 && idade < 120;
            bool sit03 = idade >= 18 && idade < 65;

            Console.WriteLine($"Votar é impossível:{sit01}");
            Console.WriteLine($"Votar é opcional: {sit02}");
            Console.WriteLine($"Votar é obrigatório: {sit03}");
            Console.ReadKey();
        }
    }
}