using Courier_Management_System_C_.Models;
namespace Courier_Management_System_C_.Repository
{
    internal interface ICourierUserService
    {
        string PlaceOrder(Courier courierObj);
        string GetOrderStatus(string trackingNumber);
        bool CancelOrder(string trackingNumber);
        List<Courier> GetAssignedOrders(string courierStaffId);
    }
}
