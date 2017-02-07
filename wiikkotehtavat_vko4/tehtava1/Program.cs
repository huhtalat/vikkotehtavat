using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta=1;
            dynamonhissi hissi = new dynamonhissi();

            while (valinta != 0)
            {
                Console.WriteLine("Give a new floor number (1-5) >");
                Int32.TryParse(Console.ReadLine(), out valinta);
                hissi.SetKerros(valinta);
                Console.WriteLine("Elevator is now in floor:" + hissi.GetKerros());
            }
        }
    }
}