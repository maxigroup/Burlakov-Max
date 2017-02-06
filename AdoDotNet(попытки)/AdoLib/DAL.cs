using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoLib
{
    public class DAL
    {
        private string ConnectionString { get; set; }

        public DAL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        //Задание 1
        public List<Entities.Orders> getOrders()
        {
            var orders = new List<Entities.Orders>();
            using (IDbConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                var command = connection.CreateCommand();
                //Пожалуйста, извините!
                command.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";
                command.CommandType = CommandType.Text;
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Entities.Orders temp = new Entities.Orders(reader["OrderID"], reader["CustomerID"], 
                            reader["EmployeeID"], reader["OrderDate"], reader["RequiredDate"], 
                            reader["ShippedDate"], reader["ShipVia"], reader["Freight"], reader["ShipName"], 
                            reader["ShipAddress"], reader["ShipCity"], reader["ShipRegion"], reader["ShipPostalCode"], 
                            reader["ShipCountry"]);
                        orders.Add(temp);
                    }
                }
            }
            return orders;
        }
        
        //Задание 2

    }
}
