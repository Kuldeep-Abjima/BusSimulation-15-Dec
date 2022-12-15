using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusSimulation
{
    public  class PassengerGenerator
    {
        private static int _count = 0;

        private static Random _rmd = new Random();
        public static Passenger CreatePassanger()
        {
            string destination = _rmd.Next(2) == 0 ? "Jaipur" : "Ajmer";
            return new Passenger($"Person {++_count}", destination);

        }
    }
}
