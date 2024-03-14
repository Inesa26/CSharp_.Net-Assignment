using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{ public class App
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 4);
            car1.Drive();
            car1.Specification();

            Truck truck1 = new Truck("Ford", "F-150", 2000);
            truck1.Drive();
            truck1.Specification();

            Vehicle cloneCar1 = (Vehicle)car1.Clone();
            Console.WriteLine($"Cloned car specification: {cloneCar1}");
            cloneCar1.Specification();

            Car car2 = (Car)cloneCar1;
            car2.Specification();

            VehicleCollection vehicles = new VehicleCollection();
            vehicles.AddVehicle(car1);
            vehicles.AddVehicle(truck1);

            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
