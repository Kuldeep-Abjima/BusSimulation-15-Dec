using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSimulation
{
    public class BusStop
    {
        private Queue<Passenger> _peopleWaiting = new Queue<Passenger>();


        public void PersonArrived(Passenger passenger)
        {
            _peopleWaiting.Enqueue(passenger);
            Console.WriteLine($"{passenger} queueing at bus stop");
        }
        public void BusArrive(Bus bus)
        {
            Console.WriteLine("\r\n Bus arraving at bus stop to load passanger ");
            while (bus.Space > 0 && _peopleWaiting.Count > 0)
            {
                Passenger passenger = _peopleWaiting.Dequeue();
                bus.Load(passenger);
            }
        }
    }
}
