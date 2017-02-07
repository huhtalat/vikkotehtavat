using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class polkupyora:kulkuneuvo
    {
        bool gearwheels;
        string gearname;

        public bool Gearwheels
        {
            get
            {
                return gearwheels;
            }

            set
            {
                gearwheels = value;
            }
        }

        public string Gearname
        {
            get
            {
                return gearname;
            }

            set
            {
                gearname = value;
            }
        }
    }
}
