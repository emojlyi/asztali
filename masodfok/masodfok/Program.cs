using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodfok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez a program megoldja a másodfokú egyenletet!");
            Console.WriteLine("Adja meg a főegyütthatót");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kérem adja meg az egyenlet első fokú tagját!");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kérem adja meg az egyenlet harmadik tagját!");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d < 0) 
            {
                Console.WriteLine("A diszkrimináns", d);
            }
            
            else
            {
                double szam1 = (-1) * b + Math.Sqrt(d) / 2 * a;
                double szam2 = (-1) * b - Math.Sqrt(d) / 2 * a;
                Console.WriteLine("Az első megoldás : x1={0:0.00} \n A második megoldás x2={1:0.00}", szam1, szam2);
            }
            Console.ReadKey();
        }
    }
}
