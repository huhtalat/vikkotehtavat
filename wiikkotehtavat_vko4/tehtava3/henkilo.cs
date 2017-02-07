using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class henkilo
    {
        string name;
        string profession;
        int salary;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
