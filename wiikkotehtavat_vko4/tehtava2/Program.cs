using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            polkupyora pyora = new polkupyora();
            pyora.Name = "Jopo";
            pyora.Model = "Street";
            pyora.Modelyear = 2017;
            pyora.Color = System.Drawing.Color.Red;
            pyora.Gearwheels = true;
            pyora.Gearname = "XT";

            polkupyora pp = new polkupyora();
            pp.Name = "Hessunpyora";
            pp.Model = "SuperPower";
            pp.Modelyear = 1950;
            pp.Color = System.Drawing.Color.ForestGreen;
            pp.Gearwheels = false;
            pp.Gearname = "HessuGear";

            vene vv = new vene();
            vv.Name = "Banaanilaiva";
            vv.Model = "XS9000";
            vv.Modelyear = 2010;
            vv.Color = System.Drawing.Color.Yellow;
            vv.Seatcount = 100;
            vv.Boattype = "Motorboat";

            vene asd = new vene();
            asd.Name = "Kumivene";
            asd.Model = "Bestway";
            asd.Modelyear = 2005;
            asd.Color = System.Drawing.Color.OrangeRed;
            asd.Seatcount = 1;
            asd.Boattype = "RubberDuck";

            Console.WriteLine("Bike info");
            Console.WriteLine("-Name:" + pyora.Name + " Model:" + pyora.Model + " ModelYear:" + pyora.Modelyear + " Color:" + pyora.Color.Name + " GearWheels:" + pyora.Gearwheels + " Gear Name:" + pyora.Gearname);
            Console.WriteLine();
            Console.WriteLine("Bike2 info");
            Console.WriteLine("-Name:" + pp.Name + " Model:" + pp.Model + " ModelYear:" + pp.Modelyear + " Color:" + pp.Color.Name + " GearWheels:" + pp.Gearwheels + " Gear Name:" + pp.Gearname);
            Console.WriteLine();
            Console.WriteLine("Boat info");
            Console.WriteLine("-Name:" + vv.Name + " Model:" + vv.Model + " ModelYear:" + vv.Modelyear + " Color:" + vv.Color.Name + " SeatCount:" + vv.Seatcount + " BoatType:" + vv.Boattype);
            Console.WriteLine();
            Console.WriteLine("Boat2 info");
            Console.WriteLine("-Name:" + asd.Name + " Model:" + asd.Model + " ModelYear:" + asd.Modelyear + " Color:" + asd.Color.Name + " SeatCount:" + asd.Seatcount + " BoatType:" + asd.Boattype);
            Console.WriteLine();
        }
    }
}
