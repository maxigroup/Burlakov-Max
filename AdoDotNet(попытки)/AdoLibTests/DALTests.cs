using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLib.Tests
{
    [TestClass()]
    public class DALTests
    {
        [TestMethod()]
        public void getOrdersTest()
        {
            DAL dal = new DAL("Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            var ord = dal.getOrders();
            Assert.IsNotNull(ord);
        }
    }
}