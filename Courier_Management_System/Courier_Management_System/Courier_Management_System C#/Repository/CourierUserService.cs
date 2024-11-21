using Courier_Management_System_C_.Models;
using Courier_Management_System_C_.Exceptions;

namespace Courier_Management_System_C_.Repository
{
    internal class CourierUserService: ICourierUserService
    {
        private readonly CourierCompanyCollection companyObj;

        public CourierUserService(CourierCompanyCollection companyObj)
        {
            this.companyObj = companyObj;
        }

        public string PlaceOrder(Courier courierObj)
        {
            companyObj.AddCourier(courierObj);
            return courierObj.TrackingNumber;
        }

        public string GetOrderStatus(string trackingNumber)
        {
            var courier = companyObj.GetCourierByTrackingNumber(trackingNumber);
            if (courier == null)
                throw new TrackingNumberNotFoundException("Tracking number not found!");
            return courier.Status;
        }

        public bool CancelOrder(string trackingNumber)
        {
            var removed = companyObj.RemoveCourier(trackingNumber);
            if (!removed)
                throw new TrackingNumberNotFoundException("Tracking number not found!");
            return true;
        }

        public List<Courier> GetAssignedOrders(string courierStaffId)
        {
            var allCouriers = companyObj.GetAllCouriers();
            return allCouriers.Where(c => c.UserID == courierStaffId).ToList();
        }
    }
}
