using AbstractClassesAndInterfaces;

var taurus = new Sedan("Ford", "Taurus", 5);

var suburban = new SUV("Chevrolet", "Suburban", 7);

var listOfVehicles = new List<Vehicle>() { taurus, suburban };

foreach (var vehicle in listOfVehicles) Vehicle.PrintVehicleDetails(vehicle);
