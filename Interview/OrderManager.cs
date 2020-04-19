using InterviewDAL;
using InterviewDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class OrderManager
    {
        #region 获得所有订单信息
        public List<Order> GetAllOrders()
        {
            return OrderService.GetAllOrders();
        }
        #endregion
        #region 根据订单ID查询
        public List<Order> GetOrdersByOrderID(int orderID)
        {
            return OrderService.GetOrderByOrderID(orderID);

        }
        #endregion
    }

}
