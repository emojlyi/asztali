using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool jatszujra = true;
            int min = 1;
            int max = 100;
            int tipp;
            int szam;
            int tippekszama;
            String valasz;

            while (jatszujra)
            {
                tipp = 0;
                tippekszama = 0;
                valasz = "";
                szam = random.Next(min, max + 1);

                while (tipp != szam)
                {
                    Console.WriteLine("Gondolj egy számra " + min + " - " + max + " között : ");
                    tipp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tipp: " + tipp);

                    if (tipp > szam)
                    {
                        Console.WriteLine(tipp + " :magasabb volt a tipped mint a gondolt szám!");
                    }
                    else if (tipp < szam)
                    {
                        Console.WriteLine(tipp + " :alacsonyabb volt a tipped mint a gondolt szám!");
                    }
                    tippekszama++;
                }
                Console.WriteLine("A gondolt szám: " + szam);
                Console.WriteLine("Nyertél!");
                Console.WriteLine("Tippjeid száma: " + tippekszama);

                Console.WriteLine("Akarsz újra játszani? (I/N): ");
                valasz = Console.ReadLine();
                valasz = valasz.ToUpper();

                if (valasz == "I")
                {
                    jatszujra = true;
                }
                else
                {
                    jatszujra = false;
                }
            }

            Console.WriteLine("Kössz hogy játszottál!");

            Console.ReadKey();
        
        
        }
    }
}
