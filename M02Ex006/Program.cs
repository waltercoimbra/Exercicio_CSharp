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
            float nota1 = 0f;
            float nota2 = 0f;
            Console.Write("Digite a primeira nota: ");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Digite a segunda nota: ");
            float.TryParse(Console.ReadLine(), out nota2);
            

            float media = (nota1 + nota2) / 2;
            
            bool sit01 = media >= 0.0 && media < 4.0;
            bool sit02 = media >= 4.0 && media < 7.0;
            bool sit03 = media >= 7.0 && media <= 10.0;

            Console.WriteLine($"A média do aluno foi {media}");
            Console.WriteLine($"O aluno foi reprovado: {sit01}");
            Console.WriteLine($"O aluno esta de recuperação: {sit02}");
            Console.WriteLine($"O aluno foi aprovado: {sit03}");
            Console.ReadKey();

        }
    }
}
