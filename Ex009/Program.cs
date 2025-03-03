using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Produto 1: "); 
            string produto1 = Console.ReadLine().Trim();
            Console.Write("Preço: R$");
            float preco1;
            float.TryParse(Console.ReadLine(), out preco1);


            Console.Write("Produto 2: ");
            string produto2 = Console.ReadLine().Trim();
            Console.Write("Preço: R$");
            float preco2;
            float.TryParse(Console.ReadLine(), out preco2);

            Console.SetCursorPosition(0, 10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{" PRODUTO ",-20}{"PREÇO  ",13}");
            Console.ResetColor();


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{produto1,-20}{preco1,13:C}");
            Console.WriteLine($"{produto2,-20}{preco2,13:C}");
            
            
            Console.ReadKey();

        }
    }
}
