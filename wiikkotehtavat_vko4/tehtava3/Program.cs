using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            henkilo employee = new henkilo();
            employee.Name = "Arttu Viskari";
            employee.Profession = "Teacher";
            employee.Salary = 1000;

            pomo Boss = new pomo();
            Boss.Name = "Matti Nykanen";
            Boss.Profession = "Head of Institute";
            Boss.Salary = 110000;
            Boss.Car = "Ferrari";
            Boss.Bonus = 50000;

            henkilo asd = new henkilo();
            asd.Name = "Vesku Loiri";
            asd.Profession = "Principal Teacher";
            asd.Salary = 9000;

            henkilo abc = new henkilo();
            abc.Name = "Foxtrot Nanonano";
            abc.Profession = "Teacher";
            abc.Salary = 50;

            Console.WriteLine("Boss:");
            Console.WriteLine("- Name:" + Boss.Name + " Profession:" + Boss.Profession + " Salary:" + Boss.Salary + " Car:" + Boss.Car + " Bonus:" + Boss.Bonus);
            Console.WriteLine();
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name:" + employee.Name + " Profession:" + employee.Profession + " Salary:" + employee.Salary);
            Console.WriteLine();
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name:" + asd.Name + " Profession:" + asd.Profession + " Salary:" + asd.Salary);
            Console.WriteLine();
            Console.WriteLine("Employee:");
            Console.WriteLine("- Name:" + abc.Name + " Profession:" + abc.Profession + " Salary:" + abc.Salary);
            Console.WriteLine();
        }
    }
}
