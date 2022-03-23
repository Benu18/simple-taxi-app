using System;

namespace Taxii
{
    class taxi
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }

        public void taxiinfo()
        {
            string duty;

            if(onduty)
            {
                duty = "yes";
            }
            else
            {
                duty = "no";
            }

            Console.WriteLine("Driver Name : {0}", drivername);
            Console.WriteLine("On Duty : {0}", duty);
            Console.WriteLine("Number of Passenger : {0}", numpassenger);
        }
        public void pickuppassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang ", drivername);
        }
        public void droppofpassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang ", drivername);
        }
    }
}
