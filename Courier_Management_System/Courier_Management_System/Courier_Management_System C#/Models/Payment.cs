using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Models
{
    internal class Payment
    {
        private long paymentID;
        private long courierID;
        private double amount;
        private DateTime paymentDate;

        public Payment() { }

        public Payment(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.courierID = courierID;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }

        public long PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public long CourierID
        {
            get { return courierID; }
            set { courierID = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public override string ToString()
        {
            return $"Payment [PaymentID={paymentID}, CourierID={courierID}, Amount={amount}, PaymentDate={paymentDate}]";
        }
    }
}
