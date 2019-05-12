using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, operacion;
            int c, n;

            Console.WriteLine("---CALCULADORA BASICA---");

            do
            {
                Console.WriteLine("Elija la operacion que quiere realizar: ");

                Console.WriteLine("Suma Opcion: A");
                Console.WriteLine("Resta Opcion: B");
                Console.WriteLine("Multiplicacion Opcion: C");
                Console.WriteLine("Division Opcion: D");

                c = char.Parse(Console.ReadLine());

                Console.Write("Ingrese valor de a: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Ingrese valor de b: ");
                b = double.Parse(Console.ReadLine());


                switch (c)
                {
                    case 'A':
                        operacion = a + b;
                        Console.Write("Resultado = ");
                        Console.Write(operacion + "\r\n");
                        Console.ReadKey(); break;
                    case 'B':
                        operacion = a - b;
                        Console.Write("Resultado = ");
                        Console.Write(operacion + "\r\n");
                        Console.ReadKey(); break;
                    case 'C':
                        operacion = a * b;
                        Console.Write("Resultado = ");
                        Console.Write(operacion + "\r\n");
                        Console.ReadKey(); break;
                    case 'D':
                        operacion = a / b;
                        Console.Write("Resultado = ");
                        Console.Write(operacion + "\r\n");
                        Console.ReadKey(); break;
                }
                Console.WriteLine("Desea realiar otra operacion?- Si = 1, No = 0");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n != 0);

        }
    }
}
