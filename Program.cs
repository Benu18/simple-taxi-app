using System;

namespace Taxii
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi Taxi = new taxi();
            Taxi.drivername = "Agus";
            Taxi.onduty = true;
            Taxi.numpassenger = 10;

            Taxi.taxiinfo();
            Taxi.pickuppassenger();
            Taxi.droppofpassenger();

            Console.ReadKey();

        }
    }
}