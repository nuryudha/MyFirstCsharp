using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCsharp
{
    public class MethodOverloading_14
    {
        // Overloading adalah menambahkan method baru 
        public void MethodOverloading()
        {
            // jadi disni ketika nilainya 11 maka dia akan ke print yang bulat kalau 11.5 maka akan ke double begitupun yang string kalau dikasih petik("")
            // Print(11);
            // Print(11.5);
            // Print("11san");

            int n = 5;
            // int hasilFactorial = Factorial(n);
            // Console.WriteLine($"Nilai Factorial dari {n}! adalah {hasilFactorial} ");
            gambarPyramid(n);




        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void gambarPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static int FactorialFor(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Print(int a)
        {
            Console.WriteLine("Nilai Bulat : " + a);
        }

        static void Print(double a)
        {
            Console.WriteLine("Nilai Double : " + a);
        }

        static void Print(string a)
        {
            Console.WriteLine("Nilai String : " + a);
        }
    }
}