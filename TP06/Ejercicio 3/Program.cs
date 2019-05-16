using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char res = 'S';
            double num1, num2, resultado;
            while (res == 'S')
            {
                Console.Write("Ingrese Num:");
                num1 = double.Parse(Console.ReadLine());
                resultado = Math.Abs(num1);
                Console.Write("\nValor absoluto:" + resultado);
                resultado = Math.Pow(num1, 2);
                Console.Write("\nPotencia:" + resultado);
                resultado = Math.Sqrt(num1);
                Console.Write("\nRaiz Cuadrada:" + resultado);
                resultado = Math.Sin(num1);
                Console.Write("\nSeno:" + resultado);
                resultado = Math.Cos(num1);
                Console.Write("\nCoseno:" + resultado);
                Console.Write("\nIngrese Num Decimal:");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("\nParte Entera:" + Math.Truncate(num1));
                Console.Write("\nIngrese Num1:");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("\nIngrese Num2:");
                num2 = double.Parse(Console.ReadLine());
                resultado = Math.Max(num1, num2);
                Console.Write("\nMayor:" + resultado);
                resultado = Math.Min(num1, num2);
                Console.Write("\nMenor:" + resultado);
                Console.Write("\nQuiere seguir operando?(S/N):");
                res = char.Parse(Console.ReadLine());
            }

        }
    }
}
