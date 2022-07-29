using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    public class SUV : Vehicle
    {
        //constructor
        public SUV(string make, string model, int numOfSeats)
        {
            Make = make;
            Model = model;
            NumOfSeats = numOfSeats;
        }

        //properties
        public bool HatchIsOpen { get; set; }
        public bool SeatbeltsAreEngaged { get; set; }

        //methods
        public void OpenHatch()
        {
            if (HatchIsOpen) Console.WriteLine("Hatch is already open");
            else
            {
                HatchIsOpen = true;
                Console.WriteLine("Hatch opened");
            }
        }

        public override void Honk()
        {
            Console.Beep(250, 500);
        }

        public override void TurnOn() //we are modifying (overriding) the TurnOn() method from the Vehicle class
        {
            if (_isOn) Console.WriteLine("Vehicle is already running");
            else if (!SeatbeltsAreEngaged) Console.WriteLine("Seatbelts must be worn in order to turn on the vehicle");
            else
            {
                _isOn = true;
                Console.WriteLine($"{Make} {Model} turned on");
            }
        }
    }
}
