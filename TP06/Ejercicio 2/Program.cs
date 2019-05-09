using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char res = 'S';
            int num1, num2, op,resultado;
            while (res == 'S'){
                Console.Write("Elija su operacion:\n 1- Sumar\n 2- Restar\n 3- Multiplicar\n 4- Dividir\n");
                op = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Num2:");
                num2 = int.Parse(Console.ReadLine());
                switch (op){
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                    default:
                        resultado = -999;
                        break;
                }
                Console.Write("Resultado:" + resultado);
                Console.Write("\nQuiere seguir operando?(S/N):");
                res = char.Parse(Console.ReadLine());
            }
            
        }
    }
}
