using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Smart_Med_Tracking_System
{
    public class Database
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SmartMed;Integrated Security=True;Encrypt=False";
        //method to it that checks the login details.
        public bool ValidateLogin(string username, string password, string role)
        {
            string query = @"
                SELECT COUNT(*)
                FROM vaccine.Users
                WHERE username = @username
                  AND userPassword = @password
                  AND userRole = @role";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);

                connection.Open();

                int matchingUsers = Convert.ToInt32(command.ExecuteScalar());
                return matchingUsers > 0;
            }
        }

        public DataTable GetVaccines()
        {
            string query = @"
                SELECT vaccineId, vaccineName, manufacturer, batchNumber,
                       expiryDate, minTemp, maxTemp, quantity
                FROM vaccine.vaccines
                ORDER BY vaccineName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetShipmentsAndSensors()
        {
            string query = @"
                SELECT
                    s.shipmentId,
                    v.vaccineName,
                    v.batchNumber,
                    s.sourceLocation,
                    s.destinationLocation,
                    s.shipmentDate,
                    se.sensorType,
                    se.sensorStatus,
                    se.vibration
                FROM vaccine.shipments AS s
                INNER JOIN vaccine.vaccines AS v
                    ON v.vaccineId = s.vaccineId
                LEFT JOIN vaccine.sensors AS se
                    ON se.shipmentId = s.shipmentId
                ORDER BY s.shipmentDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetInventoryTransactions()
        {
            string query = @"
                SELECT
                    t.inventoryId,
                    v.vaccineName,
                    v.batchNumber,
                    t.quantityReceived,
                    t.transactionDate
                FROM vaccine.inventoryTransactions AS t
                LEFT JOIN vaccine.vaccines AS v
                    ON v.vaccineId = t.vaccineId
                ORDER BY t.transactionDate DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetNotifications()
        {
                    string query = @"
                SELECT
                    n.notificationId,
                    n.notificationType,
                    n.infoMessages,
                    n.dateCreated,
                    v.vaccineName,
                    v.batchNumber
                FROM vaccine.notifications AS n
                LEFT JOIN vaccine.vaccines AS v
                    ON v.vaccineId = n.vaccineId
                ORDER BY n.dateCreated DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetUsers()
        {
            string query = @"
                            SELECT userId, username, identityNumber, email, userRole
                            FROM vaccine.Users
                            ORDER BY username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetShipmentsForDestination(string destination)
        {
            string query = @"
                SELECT
                    s.shipmentId,
                    v.vaccineName,
                    v.batchNumber,
                    s.sourceLocation,
                    s.destinationLocation,
                    s.shipmentDate,
                    se.sensorType,
                    se.sensorStatus,
                    se.vibration
                FROM vaccine.shipments AS s
                INNER JOIN vaccine.vaccines AS v
                    ON v.vaccineId = s.vaccineId
                LEFT JOIN vaccine.sensors AS se
                    ON se.shipmentId = s.shipmentId
                WHERE s.destinationLocation = @destination
                ORDER BY s.shipmentDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@destination", destination);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void AddVaccine(
            string vaccineName,
            string manufacturer,
            string batchNumber,
            DateTime expiryDate,
            decimal minTemp,
            decimal maxTemp,
            int quantity)
        {
            string query = @"
                INSERT INTO vaccine.vaccines
                    (vaccineName, manufacturer, batchNumber, expiryDate,
                     minTemp, maxTemp, quantity)
                VALUES
                    (@vaccineName, @manufacturer, @batchNumber, @expiryDate,
                     @minTemp, @maxTemp, @quantity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vaccineName", vaccineName);
                command.Parameters.AddWithValue("@manufacturer", manufacturer);
                command.Parameters.AddWithValue("@batchNumber", batchNumber);
                command.Parameters.AddWithValue("@expiryDate", expiryDate);
                command.Parameters.AddWithValue("@minTemp", minTemp);
                command.Parameters.AddWithValue("@maxTemp", maxTemp);
                command.Parameters.AddWithValue("@quantity", quantity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetVaccineById(int vaccineId)
        {
            string query = @"
                SELECT vaccineId, vaccineName, manufacturer, batchNumber,
                       expiryDate, minTemp, maxTemp, quantity
                FROM vaccine.vaccines
                WHERE vaccineId = @vaccineId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vaccineId", vaccineId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void UpdateVaccine(
            int vaccineId,
            string vaccineName,
            string manufacturer,
            string batchNumber,
            DateTime expiryDate,
            decimal minTemp,
            decimal maxTemp,
            int quantity)
        {
            string query = @"
                UPDATE vaccine.vaccines
                SET vaccineName = @vaccineName,
                    manufacturer = @manufacturer,
                    batchNumber = @batchNumber,
                    expiryDate = @expiryDate,
                    minTemp = @minTemp,
                    maxTemp = @maxTemp,
                    quantity = @quantity
                WHERE vaccineId = @vaccineId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vaccineId", vaccineId);
                command.Parameters.AddWithValue("@vaccineName", vaccineName);
                command.Parameters.AddWithValue("@manufacturer", manufacturer);
                command.Parameters.AddWithValue("@batchNumber", batchNumber);
                command.Parameters.AddWithValue("@expiryDate", expiryDate);
                command.Parameters.AddWithValue("@minTemp", minTemp);
                command.Parameters.AddWithValue("@maxTemp", maxTemp);
                command.Parameters.AddWithValue("@quantity", quantity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteVaccine(int vaccineId)
        {
            string query = @"
                DELETE FROM vaccine.vaccines
                WHERE vaccineId = @vaccineId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vaccineId", vaccineId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RegisterUser(
            string identityNumber,
            string username,
            string password,
            string email,
            string role)
        {
                    string query = @"
                INSERT INTO vaccine.Users
                    (identityNumber, username, userPassword, email, userRole)
                VALUES
                    (@identityNumber, @username, @password, @email, @role)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@identityNumber", identityNumber);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@role", role);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetOrdersForDestination(string destination)
        {
            string query = @"
                SELECT
                    o.orderId,
                    v.vaccineName,
                    v.batchNumber,
                    o.quantityOrdered,
                    o.orderDate,
                    s.shipmentId,
                    s.sourceLocation,
                    s.destinationLocation
                FROM vaccine.orders AS o
                INNER JOIN vaccine.vaccines AS v
                    ON v.vaccineId = o.vaccineId
                INNER JOIN vaccine.shipments AS s
                    ON s.shipmentId = o.shipmentId
                WHERE s.destinationLocation = @destination
                ORDER BY o.orderDate DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@destination", destination);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public DataTable GetShipmentsForOrderSelection(string destination)
        {
            string query = @"
        SELECT
            s.shipmentId,
            v.vaccineName,
            v.batchNumber
        FROM vaccine.shipments AS s
        INNER JOIN vaccine.vaccines AS v
            ON v.vaccineId = s.vaccineId
        WHERE s.destinationLocation = @destination
        ORDER BY s.shipmentDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@destination", destination);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    table.Columns.Add("shipmentDisplay", typeof(string));

                    foreach (DataRow row in table.Rows)
                    {
                        row["shipmentDisplay"] =
                            "Shipment " + row["shipmentId"] +
                            " - " + row["vaccineName"] +
                            " - Batch " + row["batchNumber"];
                    }

                    return table;
                }
            }
        }

        public void AddOrder(int shipmentId, int quantityOrdered, DateTime orderDate)
        {
            string query = @"
        INSERT INTO vaccine.orders
            (vaccineId, quantityOrdered, orderDate, shipmentId)
        SELECT vaccineId, @quantityOrdered, @orderDate, shipmentId
        FROM vaccine.shipments
        WHERE shipmentId = @shipmentId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@shipmentId", shipmentId);
                command.Parameters.AddWithValue("@quantityOrdered", quantityOrdered);
                command.Parameters.AddWithValue("@orderDate", orderDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetOrderById(int orderId)
        {
            string query = @"
                SELECT orderId, quantityOrdered, orderDate, shipmentId
                FROM vaccine.orders
                WHERE orderId = @orderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderId", orderId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void UpdateOrder(
            int orderId,
            int shipmentId,
            int quantityOrdered,
            DateTime orderDate)
        {
            string query = @"
                UPDATE o
                SET o.vaccineId = s.vaccineId,
                    o.quantityOrdered = @quantityOrdered,
                    o.orderDate = @orderDate,
                    o.shipmentId = s.shipmentId
                FROM vaccine.orders AS o
                INNER JOIN vaccine.shipments AS s
                    ON s.shipmentId = @shipmentId
                WHERE o.orderId = @orderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderId", orderId);
                command.Parameters.AddWithValue("@shipmentId", shipmentId);
                command.Parameters.AddWithValue("@quantityOrdered", quantityOrdered);
                command.Parameters.AddWithValue("@orderDate", orderDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(int orderId)
        {
            string query = @"
        DELETE FROM vaccine.orders
        WHERE orderId = @orderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@orderId", orderId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
