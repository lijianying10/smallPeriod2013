using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace sp_DAL
{
    public  class SqlHealper
    {
        private string connectionString;

        private string strSQL;
        private SqlConnection myConnection;
        private SqlCommandBuilder sqlCmdBld;
        private DataSet ds = new DataSet();
        private SqlDataAdapter da;

        public SqlHealper()
        {
            //get connection string 
            string domain = "", user = "", passwd = "", database = "";
            XmlReader.Read(ref domain, ref user, ref passwd, ref database);
            this.connectionString = "server="+domain+";database="+database+";uid="+user+";pwd="+passwd;
        }

        public DataTable SelectDataBase(string tempStrSQL)
        {
            this.myConnection = new SqlConnection(connectionString);
            DataSet tempDataSet = new DataSet();
            this.da = new SqlDataAdapter(tempStrSQL, this.myConnection);
            this.da.Fill(tempDataSet);
            return tempDataSet.Tables[0];//get the first data table
        }

        public int ExecuteCMD(string tempStrSQL)
        {
            this.myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand tempSqlCommand = new SqlCommand(tempStrSQL, this.myConnection);
            int intNumber = tempSqlCommand.ExecuteNonQuery();//return impact lines
            myConnection.Close();
            return intNumber;
        }
        //end of method
    }
}
