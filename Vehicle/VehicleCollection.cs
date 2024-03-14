using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class VehicleCollection : IEnumerable
    {
        private List<Vehicle> _vehicles;

        public VehicleCollection()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return _vehicles.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            {
                return (IEnumerator)GetEnumerator();
            }
        }
    }
}
