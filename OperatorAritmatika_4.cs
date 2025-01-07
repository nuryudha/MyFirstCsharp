namespace MyFirstCsharp
{
    public class OperatorAritmatika_4
    {
        public void OperatorAritmatika()
        {
            // Inputan Angka
            Console.Write("Masukkan Angka 1 : ");
            var Input1 = Console.ReadLine();
            Console.Write("Masukkan Angka 2 : ");
            var Input2 = Console.ReadLine();

            if (int.TryParse(Input1, out int Angka1) && int.TryParse(Input2, out int Angka2))
            {
                int Jumlah = Angka1 + Angka2;
                int Kurang = Angka1 - Angka2;
                int Kali = Angka1 * Angka2;
                double Bagi = Convert.ToDouble(Angka1) / Convert.ToDouble(Angka2);
                int Mod = Angka1 % Angka2;

                Console.WriteLine("Hasil Penjumlahan : " + Jumlah);
                Console.WriteLine("Hasil Pengurangan : " + Kurang);
                Console.WriteLine("Hasil Perkalian : " + Kali);
                Console.WriteLine("Hasil Pembagian : " + Bagi);
                Console.WriteLine("Hasil Mod : " + Mod);
            }
            else
            {
                Console.WriteLine("Inputan Harus Angka");
            }

        }
    }
}