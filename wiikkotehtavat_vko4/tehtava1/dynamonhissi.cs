using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class dynamonhissi
    {
        int Kerros;

        public int GetKerros()
            {
                return this.Kerros;
            }
        public void SetKerros(int i)
        {
            if (i < 1)
            {
                Console.WriteLine("KERROS ON LIIAN PIENI!!HYIHYI!!");
            }
            else if (i > 5)
            {
                Console.WriteLine("kerros on liian suuri!!");
            }
            else
            {
                this.Kerros = i;
            }
        }
    }
}