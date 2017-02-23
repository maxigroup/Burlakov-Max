namespace DAL
{
    using System;
    using System.Collections.Generic;

    public interface IDAL
    {
        List<Orders> GetOrder();
        List<OrderDetail> GetOrderByID(int id);
        bool InsertOrder(Orders order);
        List<CustomOrderHist> CustomOrderHist(string custId);
        List<CustomOrderDetail> CustOrdersDetail(int id);
        bool DeleteOrder(int id);
        bool UpdateOrderDate(DateTime value, int id);
        bool UpdateShippedDate(DateTime value, int id);
    }
}
