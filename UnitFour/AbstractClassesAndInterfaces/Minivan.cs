using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    public class Minivan : Vehicle, IHatch
    {
        public Minivan(string make, string model, int numOfSeats)
        {
            Make = make;
            Model = model;
            NumOfSeats = numOfSeats;
        }

        public bool HatchIsOpen { get; set; }

        public override void Honk()
        {
            Console.WriteLine("AOOGA AOOGA"); ;
        }

        public void OpenHatch()
        {
            if (HatchIsOpen) Console.WriteLine("Minivan hatch is already open");
            else
            {
                HatchIsOpen = true;
                Console.WriteLine("Minivan hatch opened");
            }
        }
    }
}
