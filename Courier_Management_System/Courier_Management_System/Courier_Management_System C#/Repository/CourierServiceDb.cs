using Courier_Management_System_C_.Models;
using System;
using System.Data.SqlClient;

namespace Courier_Management_System_C_.Repository
{
    internal class CourierServiceDb
    {
        private readonly string connectionString;

        public CourierServiceDb(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertCourier(Courier courier)
        {
            string query = @"INSERT INTO Courier 
                             (TrackingNumber, SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, DeliveryDate, UserID) 
                             VALUES 
                             (@TrackingNumber, @SenderName, @SenderAddress, @ReceiverName, @ReceiverAddress, @Weight, @Status, @DeliveryDate, @UserID)";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@TrackingNumber", courier.TrackingNumber);
                    command.Parameters.AddWithValue("@SenderName", courier.SenderName);
                    command.Parameters.AddWithValue("@SenderAddress", courier.SenderAddress);
                    command.Parameters.AddWithValue("@ReceiverName", courier.ReceiverName);
                    command.Parameters.AddWithValue("@ReceiverAddress", courier.ReceiverAddress);
                    command.Parameters.AddWithValue("@Weight", courier.Weight);
                    command.Parameters.AddWithValue("@Status", courier.Status);
                    command.Parameters.AddWithValue("@DeliveryDate", courier.DeliveryDate);
                    command.Parameters.AddWithValue("@UserID", courier.UserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inserting courier: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Courier GetCourier(string trackingNumber)
        {
            string query = "SELECT * FROM Couriers WHERE Tracking_number = @TrackingNumber";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@TrackingNumber", trackingNumber);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Courier(
                                senderName: reader["SenderName"].ToString(),
                                senderAddress: reader["SenderAddress"].ToString(),
                                receiverName: reader["ReceiverName"].ToString(),
                                receiverAddress: reader["ReceiverAddress"].ToString(),
                                weight: Convert.ToDouble(reader["Weight"]),
                                status: reader["Status"].ToString(),
                                deliveryDate: Convert.ToDateTime(reader["Delivery_date"]),
                                userID: reader["UserID"].ToString()
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving courier: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }

            return null;
        }
    }
}
