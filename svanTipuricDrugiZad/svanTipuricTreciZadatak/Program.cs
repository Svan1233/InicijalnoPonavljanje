using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricTreciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Upisite broj: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b / 4 == 0) { Console.WriteLine("Broj je djeljiv sa 4.") }
            else if (b / 6 == 0) { Console.WriteLine("Broj je djeljiv sa 6.") }
            else if (b / 4 == 0 && b / 6 == 0) { Console.WriteLine("Broj je djeljiv sa 4 i sa 6;") }
            else 
            { Console.WriteLine("Broj nije djeljiv ni sa 4 ni sa 6.")};

            
            Console.ReadKey();





                
                    

            
        }
    }
}
