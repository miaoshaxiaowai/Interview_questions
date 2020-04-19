using InterviewDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_questions.Controllers
{
    public class SumController : Controller
    {
        // GET: Sum
        public ActionResult Index()
        {
            temp04Entities2 db = new temp04Entities2();
            List<Order> lstOrder = db.Orders.ToList();
            int sum = 0;
            foreach (var item in lstOrder)
            {
                sum += item.OrderID;
            };
            ViewBag.sum = sum;
            return View("Index");
        }
    }
}