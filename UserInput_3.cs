namespace MyFirstCsharp
{
    public class UserInput_3
    {
        public void UserInput()
        {
            // Inputan Huruf
            Console.Write("Masukkan Inputan : ");
            var input = Console.ReadLine();
            // string input = Console.ReadLine(); 

            Console.WriteLine("Anda Memasukkan Inputan : {0}", input); // cara ini bisa
            Console.WriteLine("Anda Memasukkan Inputan 2 : " + input); // cara ini bisa

            Console.WriteLine("");

            // Inputan Angka
            Console.Write("Masukkan Angka : ");
            int angka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anda Memasukkan Angka : {0}", angka);
            Console.WriteLine("Anda Memasukkan Angka 2 : " + angka);

        }
    }
}