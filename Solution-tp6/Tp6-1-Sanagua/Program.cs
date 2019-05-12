using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_1_Sanagua
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, resto, b=0;
            string valor = "";

            Console.Write("Ingresar un numero: ");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);

            while(a != 0)
            {
                resto = a % 10;
                a = a / 10;
                b = b * 10 + resto;

            }
            Console.Write("Numero Invertido: ");
            Console.WriteLine(b);
            Console.ReadKey();


        }
    }
}
