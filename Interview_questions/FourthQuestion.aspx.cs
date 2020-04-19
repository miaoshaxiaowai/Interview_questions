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
    public partial class FourthQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql = "select * from Orders  where OrderID != (select top 1 OrderID from Orders order by OrderID desc) " +
              "and OrderID != (select top 1 OrderID from Orders)";
                DataSet ds = SQLHelper.GetDataSet(sql);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}