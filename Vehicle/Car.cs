using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public sealed class Car : Vehicle
    {   public int NumberOfDoors { get; set; }
        public Car(string brand, string model, int numberOfDoors): base(brand, model) {
            NumberOfDoors = numberOfDoors; }
        public override void Drive()
        {
            Console.WriteLine("Car is being driven");
        }

        public override void Drive(int distance) {
            Console.WriteLine($"Car is being driven for {distance} miles");
        }
        public override void Specification()
        {
            base.Specification();
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
        }

        public override object Clone()
        {
            return new Car(Brand, Model, NumberOfDoors);
        }
    }
}
