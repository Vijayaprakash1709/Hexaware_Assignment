using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Models
{
    internal class Location
    {
        private string locationID;
        private string locationName;
        private string address;

        public Location() { }

        public Location(string locationID, string locationName, string address)
        {
            this.locationID = locationID;
            this.locationName = locationName;
            this.address = address;
        }

        public string LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return $"Location [LocationID={locationID}, LocationName={locationName}, Address={address}]";
        }
    }
}
