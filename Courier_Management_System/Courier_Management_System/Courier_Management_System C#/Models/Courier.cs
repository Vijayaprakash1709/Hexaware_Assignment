using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Models
{
    internal class Courier
    {
        private static int trackingNumberCounter = 1000;
        private string courierID;
        private string senderName;
        private string senderAddress;
        private string receiverName;
        private string receiverAddress;
        private double weight;
        private string status;
        private string trackingNumber;
        private DateTime deliveryDate;
        private string userID;

        public Courier(string senderName, string senderAddress, string receiverName, string receiverAddress,
                       double weight, string status, DateTime deliveryDate, string userID)
        {
            this.courierID = Guid.NewGuid().ToString();
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.receiverName = receiverName;
            this.receiverAddress = receiverAddress;
            this.weight = weight;
            this.status = status;
            this.trackingNumber = GenerateTrackingNumber();
            this.deliveryDate = deliveryDate;
            this.userID = userID;
        }

        public string TrackingNumber
        {
            get { return trackingNumber; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string SenderName
        {
            get { return senderName; }
            set { senderName = value; }
        }

        public string SenderAddress
        {
            get { return senderAddress; }
            set { senderAddress = value; }
        }

        public string ReceiverName
        {
            get { return receiverName; }
            set { receiverName = value; }
        }

        public string ReceiverAddress
        {
            get { return receiverAddress; }
            set { receiverAddress = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string GenerateTrackingNumber()
        {
            return "TN" + (trackingNumberCounter++).ToString("D4");
        }

        public override string ToString()
        {
            return $"Courier [TrackingNumber={trackingNumber}, Sender={senderName}, Receiver={receiverName}, Status={status}, DeliveryDate={deliveryDate}]";
        }
    }
}
