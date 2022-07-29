using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces
{
    public abstract class Vehicle
    {
        //fields and properties
        protected bool _isOn; //protected access modifier allow access within this class AND any children/inheritors
        public string Make { get; init; } //init allows the property to be set only upon instantiation
        public string Model { get; init; }
        public int NumOfSeats { get; set; }

        //methods
        // virtual keyword allows inheritors of this class to override the implementation (code block) of a virtual method
        public virtual void TurnOn() 
        {
            if (_isOn) Console.WriteLine("Vehicle is already running");
            else
            {
                _isOn = true;
                Console.WriteLine($"{Make} {Model} turned on");
            }
        }

        public virtual void TurnOff()
        {
            if (!_isOn) Console.WriteLine("Vehicle is already off");
            else
            {
                _isOn = false;
                Console.WriteLine($"{Make} {Model} turned off");
            }
        }

        //Abstract methods do not have an implementation. The implementation (behavior) is written in the inheriting class
        public abstract void Honk();

        public static void PrintVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Make: ", vehicle.Make));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Model:", vehicle.Model));
            Console.WriteLine(String.Format("{0, -15} {1, -15}", "Number of seats:", vehicle.NumOfSeats));
        }
    }
}
