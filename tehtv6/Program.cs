using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtv6
{
    class Program
    {
        static void Main(string[] args)
        {
            kattila Toninkattila;
            Toninkattila = new kattila();

            Toninkattila.SetOnoff(true);
            Toninkattila.SetCelcius(100.00f);
            Toninkattila.SetLitra(0.9f);

            Console.WriteLine(Toninkattila.GetOnoff() + " " + "levy on paalla");
            Console.WriteLine(Toninkattila.GetCelcius() + "asteista vetta");
            Console.WriteLine(Toninkattila.GetLitra() + "litraa vetta");
        }
    }
}