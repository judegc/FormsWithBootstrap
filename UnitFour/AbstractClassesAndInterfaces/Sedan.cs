using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    public class Sedan : Vehicle
    {
        //constructor
        public Sedan(string make, string model, int numOfSeats)
        {
            Make = make;
            Model = model;
            NumOfSeats = numOfSeats;
        }

        //properties
        public bool TrunkIsOpen { get; set; }

        //methods
        public void OpenTrunk()
        {
            if (TrunkIsOpen) Console.WriteLine("Trunk is already open");
            else
            {
                TrunkIsOpen = true;
                Console.WriteLine("Trunk opened");
            }
        }

        public override void Honk() //use override keyword to implement an abstract or virtual method
        {
            Console.Beep(440, 200);
        }
    }
}
