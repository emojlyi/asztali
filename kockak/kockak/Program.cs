using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kockak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány alkalommal legyen feldobás? ");
            int dobsz = int.Parse(Console.ReadLine());

            Random random = new Random();
            int anniW = 0;
            int panniW = 0;

            for (int i = 0; i < dobsz; i++)
            {
                int kocka1 = random.Next(1, 7);
                int kocka2 = random.Next(1, 7);
                int kocka3 = random.Next(1, 7);

                int osszeg = kocka1 + kocka2 + kocka3;
                string nyertes = (osszeg < 10) ? "Anni" : "Panni";

                Console.WriteLine($"Dobás: {kocka1} + {kocka2} + {kocka3} = {osszeg}  Nyert: {nyertes}");

                if (nyertes == "Anni")
                {
                    anniW++;
                }
                else
                {
                    panniW++;
                }
            }

            Console.WriteLine($"\nA játék közben {anniW} alkalommal Anni, {panniW} alkalommal Panni nyert.");
            Console.ReadKey();
        }
    }
}
