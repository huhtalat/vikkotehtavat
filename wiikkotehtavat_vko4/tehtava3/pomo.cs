using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class pomo:henkilo
    {
        string car;
        int bonus;

        public string Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public int Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }
    }
}
