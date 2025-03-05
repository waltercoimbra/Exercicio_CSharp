using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura = 0f;

            Console.Write("Digite a sua altura em metros: ");
            float.TryParse(Console.ReadLine(), out altura);

            string status = (altura <= 1.70) ? "baixa" : "alta";
            Console.WriteLine($"Alguém com {altura} de altura é considerada uma pessoa {status}");
        }
    }
}
