using InterviewDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDAL
{
    public class OrderService
    {
        static string sql = "";
        #region  封装查询订单代码块
        public static List<Order> selectOrder() {
            List<Order> lstOrder = new List<Order>();
            try
            {
                DataSet ds = SQLHelper.GetDataSet(sql);
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    if (row["OrderProductID"] == DBNull.Value)//防止OrderProduct对象没值
                    {
                        Order order = new Order
                        {
                            //OrderID= row["OrderID"] == DBNull.Value ? 0: Convert.ToInt32(row["OrderID"]),
                            OrderID = Convert.ToInt32(row["OrderID"]),

                            OrderNum = row["OrderNum"].ToString(),
                            Hospital = row["Hospital"].ToString(),
                            Doctor = row["Doctor"].ToString(),
                            Patient = row["Patient"].ToString(),
                            OrderKind = row["OrderKind"].ToString(),
                            AcceptDate = row["AcceptDate"] == DBNull.Value ? new Nullable<DateTime>() : Convert.ToDateTime(row["AcceptDate"]),
                            FinishDate = row["FinishDate"] == DBNull.Value ? new Nullable<DateTime>() : Convert.ToDateTime(row["FinishDate"]),
                            Products = row["Products"].ToString(),
                            OrderProduct = new OrderProduct()
                        };
                        lstOrder.Add(order);
                    }
                    else
                    {
                        Order order = new Order
                        {
                            //OrderID= row["OrderID"] == DBNull.Value ? 0: Convert.ToInt32(row["OrderID"]),
                            OrderID = Convert.ToInt32(row["OrderID"]),
                            OrderNum = row["OrderNum"].ToString(),
                            Hospital = row["Hospital"].ToString(),
                            Doctor = row["Doctor"].ToString(),
                            Patient = row["Patient"].ToString(),
                            OrderKind = row["OrderKind"].ToString(),
                            AcceptDate = row["AcceptDate"] == DBNull.Value ? new Nullable<DateTime>() : Convert.ToDateTime(row["AcceptDate"]),
                            FinishDate = row["FinishDate"] == DBNull.Value ? new Nullable<DateTime>() : Convert.ToDateTime(row["FinishDate"]),
                            Products = row["Products"].ToString(),
                            OrderProduct = new OrderProduct()
                            {
                                OrderProductID = Convert.ToInt32(row["OrderProductID"]),
                                Product = row["Products"].ToString(),
                                Color = row["Color"].ToString(),
                                Num = Convert.ToDecimal(row["Num"]),
                                Price = row["Price"] == DBNull.Value ? 0 : Convert.ToInt32(row["Price"]),
                                SumPrice = row["SumPrice"] == DBNull.Value ? 0 : Convert.ToInt32(row["SumPrice"]),

                            }
                        };
                        lstOrder.Add(order);
                    }
                };
                return lstOrder;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        #endregion
        #region 查询所有的订单
        public static List<Order> GetAllOrders() {
            
            sql = "select * from Orders left join OrderProduct on Orders.OrderID=OrderProduct.OrderID ";
            return selectOrder();
                         
        }
        #endregion
        #region 根据OrderID来查询所有订单
        public static List<Order> GetOrderByOrderID(int orderID) {
            List<Order> lstOrder = new List<Order>();
            sql = "select * from Orders left join OrderProduct on Orders.OrderID=OrderProduct.OrderID where Orders.OrderID='{0}'";
            sql= string.Format(sql, orderID);
            return selectOrder();

        }
        #endregion

    }
}
