using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCsharp
{
    public class AssignmentOperator_5
    {
        public void AssignmentOperator()
        {
            int x = 30;
            int y = 30;
            // Increment Postfix
            int a1 = x++;
            // Increment Prefix
            int a2 = ++x;

            // Decrement Postfix
            int b1 = y--;
            // Decrement Prefix
            int b2 = --y;

            Console.WriteLine("Nilai A Postfix : " + a1);
            Console.WriteLine("Nilai A Prefix : " + a2);
            Console.WriteLine("Nilai B Postfix: " + b1);
            Console.WriteLine("Nilai B Prefix: " + b2);


        }
    }
}