using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Maximum_kiválasztás
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i = 0, max = 0, min = 0;
            Random vsz = new Random();



            for (i = 0; i < 10; i++)
            {
                a[i] = vsz.Next(501);
                Console.Write("{0,10}", a[i]);
            }



            max = a[0];
            for (i = 1; i < 10; i++)
            {
                if (a[i] > max) max = a[i]; 
            }



            min = a[0];
            for (i = 1; i < 10; i++)
            {
                if (a[i] < min) min = a[i];
            }



            Console.WriteLine();
            Console.WriteLine("A legnagyobb szám: {0}", max);
            Console.WriteLine("A legkisebb szám: {0}", min);





            Console.ReadKey();



        }
    }
}

