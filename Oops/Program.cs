using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Oops.Inheritance.SingleInheritance;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maruthi maruthi = new Maruthi();
            maruthi.Model = "alto";
            maruthi.color = "white";
            maruthi.price = 200000;
            maruthi.milage = 22;
            //maruthi.PrintCarInformation();
            //maruthi.PrintMilage();
            Console.ReadLine();
        }
    }
}
