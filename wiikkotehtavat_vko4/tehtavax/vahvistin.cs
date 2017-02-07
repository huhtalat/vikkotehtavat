using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavax
{
    class vahvistin
    {
        int volume;

        public int GetVolume()
            {
            return this.volume;
            }
        public void SetVolume(int i)
            {
            if (i < 0)
            {
                Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : 0");
            }
            else if (i > 100)
            {
                Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : 100");
            }
            else
            {
                this.volume = i;
            }
        }
    }
}