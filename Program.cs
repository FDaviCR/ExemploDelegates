using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExemploDelegates.Models;

namespace ExemploDelegates
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Operacao o = new Operacao(Calculadora.Somar);
            o.Invoke(10, 25);

            Operacao op = Calculadora.Multiplicar;
            op += Calculadora.Dividir;
            op.Invoke(70, 10);

            Console.ReadKey();
        }
    }
}
