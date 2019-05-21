using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char res = 'S';
            int num1, num2, resultado, op;
            string message1, message2, subcad, Palabra;
            Console.Write("\nEscriba una frase:");
            message1 = Console.ReadLine();
            Random rnd = new Random();
            Console.Write("Algunas letras: {0},{1},{2}", message1[rnd.Next() % message1.Length], message1[rnd.Next() % message1.Length], message1[rnd.Next() % message1.Length]);
            Console.Write("\nLa longitud de la cadena es: {0}", message1.Length);
            Console.Write("\nEscriba otra frase:");
            message2 = Console.ReadLine();
            subcad = (message1 + message2).Substring(0, 3);
            Console.Write("\nFrases unidas: {0}", message1 + message2);
            Console.Write("\nFragmento:{0}", subcad);
            while (res == 'S')
            {
                Console.Write("Elija su operacion:\n 1- Sumar\n 2- Restar\n 3- Multiplicar\n 4- Dividir\n");
                op = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Num1:");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Num2:");
                num2 = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.Write("La suma de {0} y {1} es igual a :{2}", num1, num2, resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.Write("La resta de {0} y {1} es igual a :{2}", num1, num2, resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.Write("La multiplicacion de {0} y {1} es igual a :{2}", num1, num2, resultado);
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.Write("La division de {0} en {1} es igual a :{2}", num1, num2, resultado);
                        break;
                    default:
                        resultado = -999;
                        break;
                }
                Console.Write("\nQuiere seguir operando?(S/N):");
                res = char.Parse(Console.ReadLine());
                foreach (char s in message1)
                    Console.Write(s);
                Console.Write("\nQue palabra desea buscar en su cadena?:");
                Palabra = Console.ReadLine();
                if (message1.Contains(Palabra))
                {
                    Console.Write("\nLa palabra esta en la cadena");
                }else
                {
                    Console.Write("\nLa palabra esta en la cadena");
                }
                Console.Write("\nMensaje en mayusculas: {0}", message1.ToUpper());
                Console.Write("\nMensaje en minusculas: {0}", message1.ToLower());
                Console.Write("\nEscriba otra frase:");
                message2 = Console.ReadLine();
                if (String.CompareOrdinal(message1, message2) <0)
                {
                    Console.Write("La cadena '{0}' es menor en valor que la cadena '{1}'", message1, message2);
                }
                if (String.CompareOrdinal(message1, message2) == 0)
                {
                    Console.Write("La cadena '{0}' es igual en valor que la cadena '{1}'", message1, message2);
                }
                if (String.CompareOrdinal(message1, message2) > 0)
                {
                    Console.Write("La cadena '{0}' es mayor en valor que la cadena '{1}'", message1, message2);
                }
                Console.Write("\nEscriba otra frase separada por /:");
                message2 = Console.ReadLine();
                string[] split = message2.Split('/');
                foreach(string s in split)
                {
                    Console.Write(s);
                    Console.Write("\n");
                }
                Console.Write("\nIngrese una operacion:");
                message2 = Console.ReadLine();
                string[] split = message2.Split(new char[] { '+', '-', '*', '/' });
                if (message1.Contains('+'){
                    resultado = [int.Parse((split[0]).Trim())] + [int.Parse((split[1]).Trim())];
                }
                if (message1.Contains('-'){
                    resultado = [int.Parse((split[0]).Trim())] - [int.Parse((split[1]).Trim())];
                }
                if (message1.Contains('*'){
                    resultado = [int.Parse((split[0]).Trim())] * [int.Parse((split[1]).Trim())];
                }
                if (message1.Contains('/'){
                    resultado = [int.Parse((split[0]).Trim())] / [int.Parse((split[1]).Trim())];
                }
                Console.Write(resultado);
                Console.ReadKey();
            }
        }
    }
}
