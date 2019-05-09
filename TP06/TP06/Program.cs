using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if(num <= 0)
            {
                Console.Write(num);
            }else
            {
                while(num > 10)
                {
                    Console.Write(num % 10);
                    num = num / 10;
                }
                Console.Write(num);
            }
            Console.ReadKey();

        }
        static public int Prueba()
        {
            return 0;
        }
    }
}
