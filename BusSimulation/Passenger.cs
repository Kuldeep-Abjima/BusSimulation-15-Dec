using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSimulation
{
    public  class Passenger
    {
        public string Name { get; set; }
        public string Destinantion { get; set; }

        public Passenger(string name, string destination)
        {
            this.Name = name;
            this.Destinantion = destination;
        }
        public override string ToString() => $"{Name} to {Destinantion}";
    }
}
