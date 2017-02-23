namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;

    public class DAL : IDAL
    {
        public DAL()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        }

        private string ConnectionString { get; set; }

        public List<Orders> GetOrder()
        {
            var orders = new List<Orders>();

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Orders";
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var order = new Orders(
                            (int)reader["OrderID"],
                            reader["CustomerID"].Equals(DBNull.Value) ? null : (string)reader["CustomerID"],
                            reader["EmployeeID"].Equals(DBNull.Value) ? null : (int?)reader["EmployeeID"],
                            reader["OrderDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["OrderDate"],
                            reader["RequiredDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["RequiredDate"],
                            reader["ShippedDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["ShippedDate"],
                            reader["ShipVia"].Equals(DBNull.Value) ? null : (int?)reader["ShipVia"],
                            reader["Freight"].Equals(DBNull.Value) ? null : (decimal?)reader["Freight"],
                            reader["ShipName"].Equals(DBNull.Value) ? null : (string)reader["ShipName"],
                            reader["ShipAddress"].Equals(DBNull.Value) ? null : (string)reader["ShipAddress"],
                            reader["ShipCity"].Equals(DBNull.Value) ? null : (string)reader["ShipCity"],
                            reader["ShipRegion"].Equals(DBNull.Value) ? null : (string)reader["ShipRegion"],
                            reader["ShipPostalCode"].Equals(DBNull.Value) ? null : (string)reader["ShipPostalCode"],
                            reader["ShipCountry"].Equals(DBNull.Value) ? null : (string)reader["ShipCountry"]);
                        orders.Add(order);
                    }
                }

                reader.Close();
                connection.Close();
                return orders;
            }
        }

        public List<OrderDetail> GetOrderByID(int id)
        {
            var orders = new List<OrderDetail>();

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                string sqlExpression = "SELECT *" +
                                       "FROM [Order Details] od INNER JOIN Orders o ON o.[OrderID] = od.[OrderID]" +
                                       "INNER JOIN Products p ON od.[ProductID] = p.[ProductID]" +
                                       "WHERE o.[OrderID] = @ID";
                var command = new SqlCommand(sqlExpression, connection);
                command.Parameters.Add("@ID", SqlDbType.Int);
                command.Parameters["@ID"].Value = id;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var order = new OrderDetail(
                            (int)reader["OrderID"],
                            reader["CustomerID"].Equals(DBNull.Value) ? null : (string)reader["CustomerID"],
                            reader["EmployeeID"].Equals(DBNull.Value) ? null : (int?)reader["EmployeeID"],
                            reader["OrderDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["OrderDate"],
                            reader["RequiredDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["RequiredDate"],
                            reader["ShippedDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["ShippedDate"],
                            reader["ShipVia"].Equals(DBNull.Value) ? null : (int?)reader["ShipVia"],
                            reader["Freight"].Equals(DBNull.Value) ? null : (decimal?)reader["Freight"],
                            reader["ShipName"].Equals(DBNull.Value) ? null : (string)reader["ShipName"],
                            reader["ShipAddress"].Equals(DBNull.Value) ? null : (string)reader["ShipAddress"],
                            reader["ShipCity"].Equals(DBNull.Value) ? null : (string)reader["ShipCity"],
                            reader["ShipRegion"].Equals(DBNull.Value) ? null : (string)reader["ShipRegion"],
                            reader["ShipPostalCode"].Equals(DBNull.Value) ? null : (string)reader["ShipPostalCode"],
                            reader["ShipCountry"].Equals(DBNull.Value) ? null : (string)reader["ShipCountry"],
                            (int)reader["ProductID"],
                            (string)reader["ProductName"],
                            (decimal)reader["UnitPrice"],
                            (short)reader["Quantity"],
                            (float)reader["Discount"]);
                        orders.Add(order);
                    }
                }

                reader.Close();
                connection.Close();
                return orders;
            }
        }

        public bool InsertOrder(Orders order)
        {
            string query = "INSERT INTO Orders VALUES (@CustomerID ,@EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia," +
                                         "@Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)";

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", order.CustomerID ?? SqlString.Null);
                command.Parameters.AddWithValue("@EmployeeID", order.EmployeeID ?? SqlInt32.Null);
                command.Parameters.AddWithValue("@OrderDate", order.OrderDate ?? SqlDateTime.Null);
                command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate ?? SqlDateTime.Null);
                command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate ?? SqlDateTime.Null);
                command.Parameters.AddWithValue("@ShipVia", order.ShipVia ?? SqlInt32.Null);
                command.Parameters.AddWithValue("@Freight", order.Freight ?? SqlDecimal.Null);
                command.Parameters.AddWithValue("@ShipName", order.ShipName ?? SqlString.Null);
                command.Parameters.AddWithValue("@ShipAddress", order.ShipAddress ?? SqlString.Null);
                command.Parameters.AddWithValue("@ShipCity", order.ShipCity ?? SqlString.Null);
                command.Parameters.AddWithValue("@ShipRegion", order.ShipRegion ?? SqlString.Null);
                command.Parameters.AddWithValue("@ShipPostalCode", order.ShipPostalCode ?? SqlString.Null);
                command.Parameters.AddWithValue("@ShipCountry", order.ShipCountry ?? SqlString.Null);
                
                if (order.CustomerID == null && order.EmployeeID == null && order.OrderDate == null &&
                    order.RequiredDate == null && order.ShippedDate == null && order.ShipVia == null &&
                    order.Freight == null && order.ShipName == null && order.ShipAddress == null &&
                    order.ShipCity == null && order.ShipRegion == null && order.ShipPostalCode == null &&
                    order.ShipCountry == null)
                {
                    return false;
                }

                command.ExecuteNonQuery();
                return true;
            }
        }

        public List<CustomOrderHist> CustomOrderHist(string custId)
        {
            var TotalSumProduct = new List<CustomOrderHist>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "[CustOrderHist]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", custId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var custHIts = new CustomOrderHist(
                            (string)reader["ProductName"],
                            reader["Total"].Equals(DBNull.Value) ? null : (int?)reader["Total"]);
                        TotalSumProduct.Add(custHIts);
                    }
                }
                reader.Close();
                connection.Close();
                return TotalSumProduct;
            }
        }

        public List<CustomOrderDetail> CustOrdersDetail(int id)
        {
            var CusrOrderDet = new List<CustomOrderDetail>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "[CustOrdersDetail]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OrderID", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var custHits = new CustomOrderDetail(
                            (string)reader["ProductName"],
                            (decimal)reader["UnitPrice"],
                            (short)reader["Quantity"],
                            (int)reader["Discount"],
                            (decimal)reader["ExtendedPrice"]);
                        CusrOrderDet.Add(custHits);
                    }
                }

                reader.Close();
                connection.Close();
                return CusrOrderDet;
                
            }
        }

        private bool Update(string date, DateTime value, int id, string query)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value", value);
                command.Parameters.AddWithValue("@OrderId", id);
                return command.ExecuteNonQuery().Equals(0) ? false : true; ;
            }
        }

        public bool UpdateOrderDate(DateTime value, int id)
        {
            string query = "UPDATE Orders SET OrderDate = CONVERT(DATETIME,@Value,101) WHERE OrderID = @OrderId";
            return Update("ShippedDate", value, id, query);
        }

        public bool UpdateShippedDate(DateTime value, int id)
        {
            string query = "UPDATE Orders SET ShippedDate = CONVERT(DATETIME,@Value,101) WHERE OrderID = @OrderId AND OrderDate < CONVERT(DATETIME,@Value,101)";
            return Update("ShippedDate", value, id, query);
        }

        public bool DeleteOrder(int id)
        {
            string queryDelete = string.Format("Delete from Orders where OrderID = '{0}'", id);
            string queryUpdateIncrement = string.Format("DBCC CHECKIDENT('Orders', RESEED, {0})", id == GetLastId ? GetLastId - 1 : GetLastId);

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var command = connection.CreateCommand();
                    command.CommandText = queryUpdateIncrement;
                    command.CommandText += queryDelete;
                    command.Transaction = transaction;
                    transaction.Commit();
                    return command.ExecuteNonQuery().Equals(0) ? false : true;
                }
                
            }
        }
        
        public int GetCount => ExecScalar("SELECT COUNT(*) FROM Orders");

        public int GetLastId => ExecScalar("SELECT MAX(OrderID) FROM Orders");
        

        private int ExecScalar(string query)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
