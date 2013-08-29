using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sp_DAL;
using System.Data;

namespace SP_BLL
{
    public class user
    {
        public int index;
        public string ID;
        public string Name;
        public string Pwd;
        public int Role;
        public int Limit;

        public user() { }

        public user(string _ID, string _Name, string _Pwd, int _Role, int _Limit)
        {
            this.ID = _ID;
            this.Name = _Name;
            this.Pwd = _Pwd;
            this.Role = _Role;
            this.Limit = _Limit;
        }

        public void initial_from_ID(string ID)
        {
            SqlHealper sh = new SqlHealper();
            DataTable dt = new DataTable();
            dt = sh.SelectDataBase("select * from tbl_U where U_ID = '"+ID+"'");
            this.index = Convert.ToInt32(dt.Rows[0]["U_index"].ToString());
            this.ID = dt.Rows[0]["U_ID"].ToString();
            this.Name = dt.Rows[0]["U_Name"].ToString();
            this.Pwd = dt.Rows[0]["U_Pwd"].ToString();
            this.Role = Convert.ToInt32(dt.Rows[0]["U_Role"].ToString());
            this.Limit = Convert.ToInt32(dt.Rows[0]["U_Limit"].ToString());
        }

        public static DataTable get_user_table()
        {
            SqlHealper sh = new SqlHealper();
            return  sh.SelectDataBase("select * from tbl_U");
        }

        public bool add()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD(
                     "insert into tbl_U( U_ID, U_Name, U_Pwd, U_Role, U_Limit)"+
                    "values"+
                    "('"+this.ID+"','"+this.Name+"','"+this.Pwd+"',"+this.Role.ToString()+","+this.Limit.ToString()+")"
                 );
            }
            catch 
            {
                return false;
            }

            return true;
        }

        public static void delete_by_index(string index)
        {
            SqlHealper sh = new SqlHealper();
            sh.ExecuteCMD("delete tbl_U where U_index = " + index.ToString());
        }

        public void update_index()
        {
            SqlHealper sh = new SqlHealper();
            DataTable dt = sh.SelectDataBase("select U_index from tbl_U where U_ID='" + this.ID + "'");
            this.index = Convert.ToInt32(dt.Rows[0]["U_index"].ToString());
            return;
        }

        public bool update_by_index()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD(
                    "update tbl_U "+
                    "set U_ID = '"+this.ID+"',"+
                    "U_Name = '"+this.Name+"',"+
                    "U_pwd = '"+this.Pwd+"',"+
                    "U_role = '"+this.Role+"',"+
                    "U_Limit = '"+this.Limit+"'"+
                    " where U_index = "+this.index.ToString()
                    );
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
