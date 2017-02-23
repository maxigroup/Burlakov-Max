namespace DAL
{

    public class CustomOrderDetail : OrderDetail
    {
        public CustomOrderDetail()
        {
        }

        public CustomOrderDetail(string ProductName, decimal UnitPrice, short Quantity, int Discount, decimal ExtendedPrice)
        {
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.Discount = Discount;
            this.ExtendedPrice = ExtendedPrice;
        }

        public decimal ExtendedPrice { get; set; }
    }
}
