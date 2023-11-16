using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>
        {
            "fuvola", "csirke", "adatok", "asztal", "fogoly",
            "bicska", "farkas", "almafa", "babona", "gerinc",
            "dervis", "bagoly", "ecetes", "angyal", "boglya"
        };

            Random random = new Random();
            string rejtettSzo = szavak[random.Next(szavak.Count)];

            Console.WriteLine("Üdvözöllek a Betűkitaláló játékban!");
            Console.WriteLine("A rejtett szó 6 betűből áll. Adj meg egy tippet, vagy írd be 'stop' a játék befejezéséhez.");

            int tippekSzama = 0;
            string kitalaltSzo = new string('.', rejtettSzo.Length);

            while (kitalaltSzo != rejtettSzo)
            {
                Console.Write("Tipp: ");
                string tipp = Console.ReadLine().ToLower();

                if (tipp == "stop")
                {
                    Console.WriteLine("Játék vége. A rejtett szó: " + rejtettSzo);
                    break;
                }

                if (tipp.Length != 6)
                {
                    Console.WriteLine("A tippnek 6 karakterből kell állnia.");
                    continue;
                }

                tippekSzama++;

                for (int i = 0; i < rejtettSzo.Length; i++)
                {
                    if (rejtettSzo[i] == tipp[i])
                    {
                        kitalaltSzo = kitalaltSzo.Substring(0, i) + rejtettSzo[i] + kitalaltSzo.Substring(i + 1);
                    }
                }

                Console.WriteLine("Válasz: " + kitalaltSzo);
            }

            if (kitalaltSzo == rejtettSzo)
            {
                Console.WriteLine("Gratulálok! Kitaláltad a szót '" + rejtettSzo + "'.");
                Console.WriteLine("Tippjeid száma: " + tippekSzama);
            }

            Console.ReadLine();
        }
    }   
}
