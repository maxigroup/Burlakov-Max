using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLib.Entities
{
    public class Orders
    {
        public Orders(object OrderID, object CustomerID, object EmployeeID, object OrderDate, object RequiredDate,
            object ShippedDate, object ShipVia, object Freight, object ShipName, object ShipAddress, object ShipCity, 
            object ShipRegion, object ShipPostalCode, object ShipCountry)
        {
            //Для каждого заказа определяем его статус
            if (OrderDate == DBNull.Value)
            {
                status = States.Recieved;
            }
            else
            {
                if (ShippedDate == DBNull.Value)
                {
                    status = States.InProgress;
                }
                else
                {
                    status = States.Done;
                }
            }


        }
        public States status;
        public enum States { Recieved, InProgress, Done };
        public object OrderID { get; set; }
        public object CustomerID { get; set; }
        public object EmployeeID { get; set; }
        public object OrderDate { get; set; }
        public object RequiredDate { get; set; }
        public object ShippedDate { get; set; }
        public object ShipVia { get; set; }
        public object Freight { get; set; }
        public object ShipName { get; set; }
        public object ShipAddress { get; set; }
        public object ShipCity { get; set; }
        public object ShipRegion { get; set; }
        public object ShipPostalCode { get; set; }
        public object ShipCountry { get; set; }
    }
}
