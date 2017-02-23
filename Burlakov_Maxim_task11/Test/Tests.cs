namespace Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DAL;

    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void getOrdersTest()
        {
            DAL dal = new DAL();
            var order = dal.GetOrder();
            Assert.IsNotNull(order);
        }
        

        [TestMethod()]
        public void getOrdersByIdTest()
        {
            DAL dal = new DAL();
            var order = dal.GetOrderByID(10248);
            Assert.IsNotNull(order);
        }

        [TestMethod()]
        public void insertOrderTest()
        {
            DAL dal = new DAL();
            var ord = new Orders();
            Assert.IsTrue(dal.DeleteOrder(dal.GetLastId));
            ord.CustomerID = "MISHA";
            ord.ShipCity = "Moscow";
            Assert.IsTrue(dal.InsertOrder(ord));

        }

        [TestMethod()]
        public void notInsertOrderTest()
        {
            DAL dal = new DAL();
            var ord = new Orders();
            Assert.IsFalse(dal.InsertOrder(ord));
        }

        [TestMethod()]
        public void updateDateTest()
        {
            DAL dal = new DAL();
            Assert.IsTrue(dal.UpdateOrderDate(new DateTime(2016, 12, 15), 11074));
            Assert.IsTrue(dal.UpdateShippedDate(new DateTime(2017, 01, 15), 11074));
        }


        [TestMethod()]
        public void custOrderHistTest()
        {
            DAL dal = new DAL();
            var order = dal.CustomOrderHist("LEHMS");
            Assert.IsNotNull(order);
        }

        [TestMethod()]
        public void custOrderdDetailsTest()
        {
            DAL dal = new DAL();
            var order = dal.CustOrdersDetail(10248);
            Assert.IsNotNull(order);
        }
    }
}
