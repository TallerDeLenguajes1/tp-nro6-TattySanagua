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
            double a, b, x, operacion;
            int c, n;

            Console.WriteLine("---CALCULADORA COMPLETA---");
            Console.WriteLine("Elija la operacion que quiere realizar: ");
            Console.WriteLine("Suma: A");
            Console.WriteLine("Resta: B");
            Console.WriteLine("Multiplicacion: C");
            Console.WriteLine("Division: D");
            Console.WriteLine("Valor Absoluto: E");
            Console.WriteLine("Cuadrado: F");
            Console.WriteLine("Raiz cuadrada: G");
            Console.WriteLine("Seno: H");
            Console.WriteLine("Coseno: I");
            Console.WriteLine("Parte entera de un decimal: J");
            Console.WriteLine("Maximo: K");
            Console.WriteLine("Minimo: L");
            do
            {
                
                c = char.Parse(Console.ReadLine());

                if (c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'K' || c == 'L')
                {
                    Console.Write("Ingrese valor de a: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese valor de b: ");
                    b = double.Parse(Console.ReadLine());


                    switch (c)
                    {
                        case 'A':
                            operacion = a + b;
                            Console.WriteLine("SUMA = " + operacion);
                            Console.ReadKey(); break;
                        case 'B':
                            operacion = a - b;
                            Console.WriteLine("RESTA = " + operacion);
                            Console.ReadKey(); break;
                        case 'C':
                            operacion = a * b;
                            Console.WriteLine("MULTIPLICACION = " + operacion);
                            Console.ReadKey(); break;
                        case 'D':
                            operacion = a / b;
                            Console.WriteLine("DIVISION = " + operacion);
                            Console.ReadKey(); break;
                        case 'K':
                            operacion = Math.Max(a, b);
                            Console.WriteLine("MAXIMO = " + operacion);
                            Console.ReadKey(); break;
                        case 'L':
                            operacion = Math.Min(a, b);
                            Console.WriteLine("MINIMO = " + operacion);
                            Console.ReadKey(); break;

                    }
                }
                else
                {
                    if(c=='E' || c=='F' || c=='G' || c=='H' || c=='I' || c == 'J')
                    {
                        Console.Write("Ingrese valor de x: ");
                        x = double.Parse(Console.ReadLine());

                        switch (c)
                        {
                            case 'E':
                                operacion = Math.Abs(x);
                                Console.WriteLine("VALOR ABSOLUTO = " + operacion);
                                Console.ReadKey(); break;
                            case 'F':
                                operacion = Math.Pow(x,2);
                                Console.WriteLine("CUADRADO = " + operacion);
                                Console.ReadKey(); break;
                            case 'G':
                                operacion = Math.Sqrt(Math.Abs(x));
                                Console.WriteLine("RAIZ CUADRADA = " + operacion);
                                Console.ReadKey(); break;
                            case 'H':
                                operacion = Math.Sin(x);
                                Console.WriteLine("SENO = " + operacion);
                                Console.ReadKey(); break;
                            case 'I':
                                operacion = Math.Cos(x);
                                Console.WriteLine("COSENO = " + operacion);
                                Console.ReadKey(); break;
                            case 'J':
                                operacion = Math.Truncate(x);
                                Console.WriteLine("PARTE ENTERA DE UN DECIMAL = " + operacion);
                                Console.ReadKey(); break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay operacion asignada!!");
                    }
                }

                Console.WriteLine("Desea realiar otra operacion?- Si = 1, No = 0");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija la operacion que quiere realizar: ");
            } while (n != 0);
            
        }
    }
}
