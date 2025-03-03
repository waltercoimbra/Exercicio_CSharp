using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int nasc;
            Console.Write("Em que ano você nasceu? ");
            int.TryParse(Console.ReadLine(), out nasc);
            int ano = DateTime.Now.Year;
            int idade = ano - nasc;
            Console.WriteLine($"Atualmente estamo no ano de {ano}");
            Console.WriteLine($"Se você nasceu em {nasc} vai ter {idade} anos");
            Console.ReadKey();
            
        }
    }
}
