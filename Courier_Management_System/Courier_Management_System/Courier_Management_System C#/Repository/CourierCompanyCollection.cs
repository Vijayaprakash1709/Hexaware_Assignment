using Courier_Management_System_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Repository
{
    internal class CourierCompanyCollection
    {
        private readonly List<Courier> couriers;

        public CourierCompanyCollection()
        {
            couriers = new List<Courier>();
        }
        

        public void AddCourier(Courier courier)
        {
            couriers.Add(courier);
        }

        public List<Courier> GetAllCouriers()
        {
            return couriers.ToList();
        }

        public Courier GetCourierByTrackingNumber(string trackingNumber)
        {
            return couriers.FirstOrDefault(c => c.TrackingNumber == trackingNumber);
        }

        public bool RemoveCourier(string trackingNumber)
        {
            return couriers.RemoveAll(c => c.TrackingNumber == trackingNumber) > 0;
        }
    }
}
