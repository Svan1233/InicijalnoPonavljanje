using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricDrugiZad
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            int m;
            int o;
            Console.WriteLine("Upisite broj sekundi: " );
            s = Convert.ToInt32(Console.ReadLine());
            m = s / 60;
            o = s % 60;
            Console.WriteLine("To je " + m + " minute i " + o + " sekundi.");



            
            Console.ReadKey();
        }
    }
}
