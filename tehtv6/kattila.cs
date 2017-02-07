using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtv6
{
    class kattila
    {
        float Celcius;
        float Litra;
        bool Onoff;

        public float GetCelcius()
        {
            return this.Celcius;
        }
        public void SetCelcius(float j)
        {
            this.Celcius = j;
        }
        public float GetLitra()
        {
            return this.Litra;
        }
        public void SetLitra(float i)
        {
            this.Litra = i;
        }
        public bool GetOnoff()
        {
            return this.Onoff;
        }
        public void SetOnoff(bool x)
        {
            this.Onoff = x;
        }
        public void LevyOnPaalla()
        {
            if (Celcius == 100)
            {
                Console.WriteLine("Vesi kiehuu");
            }
            if (Celcius < 100)
            {
                Console.WriteLine("vesi ei kiehu");
            }
            if (Celcius > 100)
            {
                Console.WriteLine("varo kuumaa hoyrya!!");
            }
            if (Celcius <= 0)
            {
                Console.WriteLine("Kannattaako lammittaa jaata??");
            }
        }
        public void PrintData()
        {
            Console.WriteLine();
        }
    }
}