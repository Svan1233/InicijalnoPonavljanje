using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricSedmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 klas = new Class1();
            int[] niz = new int[5];

            for (int i = 0; i < 5; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }

            int zbroj;
            double prosjek;
            zbroj = klas.Zbroj(niz);
            prosjek = klas.Prosjek(niz);
            Console.WriteLine("Zbroj brojeva je " + zbroj + "\nProsjeka brojeva je " + prosjek);
            Console.ReadKey();
        }
    }
}
