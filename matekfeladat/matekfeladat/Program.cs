using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matekfeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] szamok = new int[28];
            int pszamok = 0;
            int nszamok = 0;
            int hetesekszama = 0;
            int nulla = -1;

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(-10, 11);

                if (szamok[i] > 0)
                    pszamok++;
                else if (szamok[i] < 0)
                    nszamok++;
                if (szamok[i] == 7)
                    hetesekszama++;
                if (szamok[i] == 0)
                    nulla = i;
            }

            Console.WriteLine("Kapott számok: " + string.Join(", ", szamok));
            Console.WriteLine("Pozitív számok : " + pszamok);
            Console.WriteLine("Negatív számok : " + nszamok);
            Console.WriteLine("Hetesek: " + hetesekszama);
            if (nulla != -1)
                Console.WriteLine("Van 0 és a(z) " + nulla + ". szám");
            else
                Console.WriteLine("Nincs 0.");

            Console.ReadKey();
        }

    }
}


