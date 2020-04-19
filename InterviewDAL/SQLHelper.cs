using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDAL
{
    public static class SQLHelper
    {
        static string connstr = @"Data Source=server03.heng9.com.cn;Initial Catalog=temp04;uid=test;pwd=test01";
        static SqlConnection conn;
        public static void initConn() {
            conn = new SqlConnection(connstr);
            conn.Open();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sqlstr) {
            initConn();
            SqlDataAdapter dat = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            dat.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
