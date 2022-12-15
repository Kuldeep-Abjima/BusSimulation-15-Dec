using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSimulation
{
    public  class Bus
    {
        public const int Capacity = 5;

        public int Space { get => Capacity - _passenger.Count; }
        private List<Passenger> _passenger = new List<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space < 1)
            {
                return false;
            }
            _passenger.Add(passenger);
            Console.WriteLine($"{passenger} got into the bus");
            return true;
        }



        public void ArrvingAt(string place)
        {
            Console.WriteLine($"Bus arrive at {place}");
            if(_passenger.Count == 0) {
                return;
            }
             
            List<Passenger> RemovePassengers = _passenger.FindAll(x => x.Destinantion == place);
            _passenger.RemoveAll(x=> x.Destinantion == place);
           foreach(var passenger in RemovePassengers)
            {
                Console.WriteLine($"{passenger} is got off");
            }
            Console.WriteLine($"{_passenger.Count} remaining in Bus");
            

        }
        //public void ArrvingAt(string place)
        //{
        //    Console.WriteLine($"\r\n Bus Arrving At {place}");
        //    if (_passenger.Count == 0)
        //    {
        //        return;
        //    }
        //    LinkedListNode<Passenger> currentNode = _passenger.First;
        //    do
        //    {
        //        LinkedListNode<Passenger> nextNode = currentNode.Next;
        //        if (currentNode.Value.Destinantion == place)
        //        {
        //            Console.WriteLine($"{currentNode.Value} is getting off");
        //            _passenger.Remove(currentNode);
        //        }
        //        currentNode = nextNode;
        //    } while (currentNode != null);
        //    Console.WriteLine($"{_passenger.Count} left on bus");

        //}
    }
}
