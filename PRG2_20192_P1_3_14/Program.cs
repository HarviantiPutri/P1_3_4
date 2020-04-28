using System;

namespace PRG2_20192_P1_3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            Console.WriteLine("PROGRAM LAGU ANAK AYAM");
            Console.WriteLine("======================");
          
           
            int i;

            for (i = N; i > 1; i--)
            {
                Console.WriteLine (" anak ayam turun {0}", i);
                Console.Write("mati satu tinggal induknya {0}", i - 1);
               
            }
            Console.Write("Anak ayam turun 1, mati satu tinggal induknya");
        }
    }
}



