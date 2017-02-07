using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class vene:kulkuneuvo
    {
        int seatcount;
        string boattype;

        public int Seatcount
        {
            get
            {
                return seatcount;
            }

            set
            {
                seatcount = value;
            }
        }

        public string Boattype
        {
            get
            {
                return boattype;
            }

            set
            {
                boattype = value;
            }
        }
    }
}
