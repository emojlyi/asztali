using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] emberek = new int[10];
            int osszeg = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Kérem a(z) {i + 1} ember jegyét.");
                emberek[i] = int.Parse( Console.ReadLine() );
                osszeg += emberek[i];
            }
            double atlag = (double)osszeg / 10;
            int darab = 0;
            for (int i = 0; i < 10; i++)
            {
                if (emberek[i] > atlag)
                    darab++;

            }
            Console.WriteLine($"ennyien érték el az átlagnál jobb eredményt  {darab}");
            Console.WriteLine($"Az átlaguk: {atlag}");
            Console.ReadKey();
        }
    }
}
