using Interview;
using InterviewDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_questions.Controllers
{
    public class OrdersController : Controller
    {
        OrderManager orderManager = new OrderManager();
        // GET: Orders

        public ActionResult Index() { 
            List<Order> lstOrders = orderManager.GetAllOrders();
            ViewBag.lstOrders = lstOrders;
            return View("Index");
        }

        public ActionResult GetOrders()
        {
            List<Order> lstOrders;
            if (Request.Form["orderID"] == "")
            {
                lstOrders = orderManager.GetAllOrders();
            }
            else
            {
                int orderID = Convert.ToInt32(Request.Form["orderID"]);
                //[2]调用BLL
                lstOrders = orderManager.GetOrdersByOrderID(orderID);
                //[3]保存数据，传递到view
                ViewBag.orderID = orderID;
            }
            
            ViewBag.lstOrders = lstOrders;
            return View("Index");
        }

    }
}