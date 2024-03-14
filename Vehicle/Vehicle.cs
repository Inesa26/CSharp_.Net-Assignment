using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class Vehicle: ICloneable
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void Drive();
        public abstract void Drive(int distance);

        public virtual void Specification()
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model}");
        }

        public abstract object Clone();

        public override string ToString()
        {
            return $"Brand: {Brand} Model: {Model}";
        }
    }
}
