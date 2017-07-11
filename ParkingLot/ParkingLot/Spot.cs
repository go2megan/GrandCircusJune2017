using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Spot
    {
        private string type;
        public bool park;

        public string Type { get => type; set => type = value; }

        public Spot (string type)
        {
            this.type = type;
        }

        public void SmallSpot(string type)
        {
            if (type == "motorcycle")
            {
                park = true;
                
            }
            else if (type == "car" || type == "bus" || type == "truck")
            {
                park = false;
            }
        }
        public void MediumSpot(string type)
        {
            if (type == "motorcycle" || type == "car" || type == "truck")
            {
                park = true;

            }
            else if (type == "bus")
            {
                park = false;
            }
        }
        public void LargeSpot(string type)
        {
            if (type == "bus")
            {
                park = true;
            }
            else if (type == "motorcycle" || type == "car" || type == "truck")
            {
                park = false;
            }
        }

    }
}
