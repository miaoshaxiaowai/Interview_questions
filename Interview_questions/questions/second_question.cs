using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Interview_questions.questions
{
    public class second_question
    {
        //#region 连接数据库

        // static string connstr = "Data Source=server03.heng9.com.cn;Initial Catalog=temp04;uid=test;pwd=test01";
        ////步骤2：创建Connection对象链接数据库（SqlConnection）
        //static SqlConnection conn;

        //public static void initConn() {
        //    conn = new SqlConnection(connstr);
        //    conn.Open();
        //}
        //static string sqlstr = "";
        //SqlDataAdapter dat = new SqlDataAdapter(sqlstr, conn);
        //DataSet ds = new DataSet();
        static string connstr = "Data Source=server03.heng9.com.cn;Initial Catalog=temp04;uid=test;pwd=test01";
        SqlConnection conn = new SqlConnection(connstr);
        


    }
}