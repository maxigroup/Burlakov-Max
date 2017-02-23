namespace DAL
{
    using System;

    public class OrderDetail : Orders
    {
        public OrderDetail()
        {

        }

        public OrderDetail(int OrderID, string CustomerID, int? EmployeeID, DateTime? OrderDate, DateTime? RequiredDate,
                                DateTime? ShippedDate, int? ShipVia, decimal? Freight, string ShipName, string ShipAddress,
                                string ShipCity, string ShipRegion, string ShipPostalCode, string ShipCountry, int ProductID,
                                string ProductName, decimal UnitPrice, short Quantity, float Discount)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.ShipVia = ShipVia;
            this.Freight = Freight;
            this.ShipName = ShipName;
            this.ShipAddress = ShipAddress;
            this.ShipCity = ShipCity;
            this.ShipRegion = ShipRegion;
            this.ShipPostalCode = ShipPostalCode;
            this.ShipCountry = ShipCountry;
            this.RequiredDate = RequiredDate;
            this.ShippedDate = ShippedDate;
            this.OrderDate = OrderDate;
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.Discount = Discount;
        }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
    }
}
