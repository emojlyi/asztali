using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivonas_szorzas_osztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a program egy számológép!");
            int a;
            Console.Write("Add meg az első számot");
            int szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a második számot");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Milyen műveletet akarsz elvégezni?(+,-,*,/):");
            string szamolas = Console.ReadLine();

            switch (szamolas)
            {
                case "+":
                    a = szam1 + szam2;
                    Console.WriteLine("Összeadás:" + a);
                    string valasz = Console.ReadLine();
                    if (szam1 == szam2)
                    {

                    }
                    break;
                case "-":
                    a = szam1 - szam2;
                    Console.WriteLine("Kivonás:" + a);
                    break;
                case "*":
                    a = szam1 * szam2;
                    Console.WriteLine("Szorzás:" + a);
                    break;
                case "/":
                    a = szam1 / szam2;
                    Console.WriteLine("Osztás:" + a);
                    break;
                default:
                    Console.WriteLine("Rossz dolgot adtál meg!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
