using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDelegates.Models
{
    internal class Calculadora
    {
        public static void Somar(int x, int y) {
            Console.WriteLine($"Adição: {x+y}");
        }

        public static void Subtrair(int x, int y) {
            Console.WriteLine($"Subtração: {x-y}");
        }

        public static void Multiplicar(int x, int y)
        {
            Console.WriteLine($"Subtração: {x * y}");
        }

        public static void Dividir(int x, int y)
        {
            Console.WriteLine($"Subtração: {x / y}");
        }
    }
}
