using System;

namespace MukemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int tpl = 0;
            Console.Write("Bir sayı girin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x - 1; i++)
            {
                if (x % i == 0)
                {
                    tpl = tpl + i;
                }
            }
            if (x == tpl)
            {
                Console.WriteLine("Girdiğiniz sayı mükemmel sayıdır");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı mükemmel sayı değildir");
            }
        }
    }
}
