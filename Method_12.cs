using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCsharp
{
    public class Method_12
    {
        public void Method()
        {
            HelloWorld();

            Console.WriteLine("");
            Console.Write("Masukkan Nama anda : ");
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Anda Belum Memasukkan Nama !");
            }
            else
            {
                HelloName(name);
            }

            Console.WriteLine("");
            Console.Write("Masukkan Angka 1 : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Hitung(a, b);

            Console.WriteLine("");
            int hasil = Jumlah(a, b);
            Console.WriteLine("hasil dari method Jumlah : " + hasil);

            Console.WriteLine("");
            string name2 = HelloName2(name);
            Console.WriteLine("HelloName2 : " + name2);


        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void HelloName(string Name)
        {
            Console.WriteLine("HelloName1 : " + Name);
        }

        //Method void itu artinya dia berjalan sendiri . kayak misahin aja  
        static void Hitung(int a, int b)
        {
            var tambah = a + b;
            var kurang = a - b;
            var kali = a * b;
            var bagi = a / b;
            Console.WriteLine("Hasil Penjumlahan : " + tambah);
            Console.WriteLine("Hasil Pengurangan : " + kurang);
            Console.WriteLine("Hasil Perkalian : " + kali);
            Console.WriteLine("Hasil Pembagian : " + bagi);
        }

        // Kalau method dengan return itu spesifik hanya bisa menjalan 1 proses aja yang dia itu mengembalikan nilai dari hasil prosesnya
        // artinya hasilnya dapat dipindahkan ke tempat lain
        static int Jumlah(int a, int b)
        {
            return a + b;
        }

        static string HelloName2(string Name)
        {
            return Name;
        }
    }

}