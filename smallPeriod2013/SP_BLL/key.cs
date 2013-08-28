using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sp_DAL;
using System.Data;

namespace smallPeriod2013
{
    public class key
    {
        public string user;
        public string passwd;
        public key(string _user, string _passwd) 
        {
            this.user = _user;
            this.passwd = _passwd;
        }

        public bool judge()
        {
            SqlHealper sh = new SqlHealper();
            DataTable dt = new DataTable();
            dt = sh.SelectDataBase("select U_pwd from tbl_U where U_ID = '"+this.user+"'");

            if (dt.Rows.Count == 0)//if the query is none result
            {
                return false;
            }

            string pwd = dt.Rows[0]["U_pwd"].ToString();
            if (pwd == this.passwd)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
