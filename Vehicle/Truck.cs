using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Truck : Vehicle
    {   public int LoadCapacity { get; set; }

        public Truck(string brand, string model, int loadCapacity) : base(brand, model)
        {
            LoadCapacity = loadCapacity;
        }

        public override void Drive()
        {
            Console.WriteLine("Truck is being driven");
        }

        public override void Drive(int distance)
        {
            Console.WriteLine($"Truck is being driven for {distance} miles");
        }

        public override void Specification()
        {
            base.Specification();
            Console.WriteLine($"Load Capacity: {LoadCapacity}");
        }

        public override object Clone()
        {
            return new Truck(Brand, Model, LoadCapacity);
        }
    }
}
