using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCsharp
{
    public class ArgumentsMethod_13
    {

        public void ArgumentsMethod()

        {
            // Ref dan Void
            int a1 = 5;
            HitungRefVoid(ref a1);
            Console.WriteLine("Hasil (ref, void): " + a1);

            // Ref dan Return
            int a2 = 5;
            int hasilRefReturn = HitungRefReturn(ref a2);
            Console.WriteLine("Nilai a setelah ref: " + a2);
            Console.WriteLine("Hasil (ref, return): " + hasilRefReturn);

            // Out di Void
            HitungOutVoid(5, 3, out int hasilOutVoid);
            Console.WriteLine("Hasil (out, void): " + hasilOutVoid);

            // Out di Return
            int hasilOutReturn = HitungOutReturn(5, 3, out int hasilKali);
            Console.WriteLine("Hasil Penjumlahan (out, return): " + hasilOutReturn);
            Console.WriteLine("Hasil Perkalian (out): " + hasilKali);

            // Tuple
            var hasilTuple = HitungTuple(10, 5);
            Console.WriteLine($"Hasil Penjumlahan (tuple): {hasilTuple.Tambah}");
            Console.WriteLine($"Hasil Pengurangan (tuple): {hasilTuple.Kurang}");


        }

        // Ref dan Void
        static void HitungRefVoid(ref int x)
        {
            x = x * x;
        }

        // Ref dan Return
        static int HitungRefReturn(ref int x)
        {
            x = x * x;
            return x + 10;
        }

        // Out di Void
        static void HitungOutVoid(int a, int b, out int hasil)
        {
            hasil = a + b;
        }

        // Out di Return
        static int HitungOutReturn(int a, int b, out int kali)
        {
            kali = a * b;
            return a + b;
        }

        // Tuple
        static (int Tambah, int Kurang) HitungTuple(int a, int b)
        {
            return (a + b, a - b);
        }






    }
}