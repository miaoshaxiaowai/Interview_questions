using InterviewDAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview_questions
{
    public partial class fifthQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from Orders left join OrderProduct on Orders.OrderID=OrderProduct.OrderID ";
            DataSet ds = SQLHelper.GetDataSet(sql);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() != "")
            {
                string sql = "select * from Orders left join OrderProduct on Orders.OrderID=OrderProduct.OrderID where Orders.OrderID=" + TextBox1.Text.Trim();
                DataSet ds = SQLHelper.GetDataSet(sql);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }   
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from Orders left join OrderProduct on Orders.OrderID=OrderProduct.OrderID ";
            DataSet ds = SQLHelper.GetDataSet(sql);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}