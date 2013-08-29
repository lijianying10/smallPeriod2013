using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using sp_DAL;

namespace SP_BLL
{
    public class MMM
    {
        public int index;
        public string ID;
        public string Classify;
        public double MakePrice;
        public double SellPrice;
        public string Unit;
        public string Memo;

        public MMM()
        { }
        public MMM(string _ID, string _Classify, double _MakePrice, double _SellPrice, string _Unit, string _Memo)
        {
            this.ID = _ID;
            this.Classify = _Classify;
            this.MakePrice = _MakePrice;
            this.SellPrice = _SellPrice;
            this.Unit = _Unit;
            this.Memo = _Memo;
        }
        
        public static DataTable refreash_table()
        { 
            SqlHealper sh = new SqlHealper();
            return sh.SelectDataBase("select M_ID as ID, M_Classify as classify, M_MakePrice as makePrice, M_SellPrice as sellprice, M_Unit as unit , M_Memo as memo from tbl_M");
        }

        public bool add()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD(
                    "insert into tbl_M"+
                     "(M_ID, M_Classify, M_MakePrice, M_SellPrice, M_Unit, M_Memo)"+
                     "values"+
                     "('"+this.ID+"','"+this.Classify+"','"+this.MakePrice+"','"+this.SellPrice+"','"+this.Unit+"','"+this.Memo+"')"
                );
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void update_index()
        {
            SqlHealper sh = new SqlHealper();
            DataTable dt = sh.SelectDataBase("select M_index from tbl_M where M_ID='" + this.ID + "'");
            this.index = Convert.ToInt32(dt.Rows[0]["M_index"].ToString());
            return;
        }

        public bool update_by_index()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD(
                    "update tbl_M " +
                    "set M_ID = '"+this.ID+"',"+
                    "M_Classify = '"+this.Classify+"',"+
                    "M_MakePrice = '"+this.MakePrice+"',"+
                    "M_SellPrice = '"+this.SellPrice+"',"+
                    "M_Unit = '"+this.Unit+"',"+
                    "M_Memo = '"+this.Memo+"' "+
                    "where M_index = "+this.index
                    );

            }
            catch
            {
                return false;
            }
            return true;
        }

        public void delete_by_index()
        {
            SqlHealper sh = new SqlHealper();
            sh.ExecuteCMD("delete tbl_M where M_index = " + this.index.ToString());
        }

        public static DataTable search(string field, string key)
        {
            SqlHealper sh = new SqlHealper();
            return sh.SelectDataBase("SELECT M_ID as ID, M_Classify as Classify, M_MakePrice as makeprice, M_SellPrice as sellprice, M_Unit as unit, M_Memo as memo FROM tbl_M where " + field + " like '%" + key + "%'");
        }
    }
}
