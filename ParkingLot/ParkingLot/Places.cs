using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Places : Spot
    {
        public string type;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private bool park;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
                              //private string type;

        public Places(string type)
        {
            this.type = type;

            //this.park = park;

        }

        public bool Park { get => park; set => park = value; }

        public void getPlaces(string type, bool park)
        {
            if (type == "motorcycle" & park == true)
            {
                Console.WriteLine("You can park in all spots.");
            }
            else if (type == "car" & park == true)
            {
                Console.WriteLine("You can park on Levels A - C and spots 6 - 10.");
            }
            else if (type == "bus" & park == true)
            {
                Console.WriteLine("You can park on Level A, only in spots 1- 5");
            }
            else if (type == "truck" & park == true)
            {
                Console.WriteLine("You can park on Levels A - C and spots 6 - 10.");
            }
        }

    }
}
