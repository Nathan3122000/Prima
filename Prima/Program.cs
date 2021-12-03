using System;

namespace Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka, i, m = 0, j = 0;
            Console.Write("Masukkan angka: ");
            angka = Convert.ToInt32(Console.ReadLine());
            m = angka / 2;
            for (i = 2; i <= m; i++)
            {
                if (angka % i == 0)
                {
                    Console.Write("Angka bukan prima");
                    j = 1;
                    break;
                }
            }
            if (j == 0)
                Console.Write("Angka prima");
        }
    }
}
