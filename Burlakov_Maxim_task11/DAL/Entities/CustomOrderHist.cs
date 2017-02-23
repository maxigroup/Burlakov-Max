namespace DAL
{

    public class CustomOrderHist : OrderDetail
    {
        public CustomOrderHist()
        {

        }

        public CustomOrderHist(string ProductName, int? Total)
        {
            this.ProductName = ProductName;
            this.Total = Total;
        }

        public int? Total { get; set; }

    }
}
