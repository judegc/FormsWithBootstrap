using AbstractClassesAndInterfaces;

var taurus = new Sedan("Ford", "Taurus", 5);

var suburban = new SUV("Chevrolet", "Suburban", 7);

var odyssey = new Minivan("Honda", "Odyssey", 8);

var listOfVehicles = new List<Vehicle>() { taurus, suburban, odyssey };

//foreach (var vehicle in listOfVehicles) Vehicle.PrintVehicleDetails(vehicle);

foreach(Vehicle vehicle in listOfVehicles)
{
    vehicle.TurnOn();
    if(vehicle is IHatch hatchVehicle)
    {
        hatchVehicle.OpenHatch();
    }
}

