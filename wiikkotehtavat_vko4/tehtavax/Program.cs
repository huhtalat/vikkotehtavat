//tehtava2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavax
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta = 75911;
            vahvistin kajari = new vahvistin();
            Console.WriteLine("Syottamalla 989416 lopetat ohjelman");

            while (valinta != 989416)
            {
                Console.WriteLine("Give a new Volume value (0-100)");
                Int32.TryParse(Console.ReadLine(), out valinta);
                kajari.SetVolume(valinta);
                Console.WriteLine("-> Amplifier volume is set to : " + kajari.GetVolume());
            }
        }
    }
}