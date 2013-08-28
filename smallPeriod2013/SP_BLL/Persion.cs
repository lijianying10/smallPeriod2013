using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sp_DAL;
using System.Data;

namespace SP_BLL
{
    public class Persion
    {
        public int index;
        public string ID;
        public string Name;
        public string Sex;
        public DateTime Birthday;
        public DateTime Jobday;
        public string Education;
        public string Department;
        public string Duty;
        public string Jobtype;

        public Persion()
        { }

        public Persion(string _id, string _name, string _sex, DateTime _birthday, DateTime _jobday, string _education, string _department,
            string _duty, string _jobtype)
        {
            this.ID = _id;
            this.Name = _name;
            this.Sex = _sex;
            this.Birthday = _birthday;
            this.Jobday = _jobday;
            this.Education = _education;
            this.Department = _department;
            this.Duty = _duty;
            this.Jobtype = _jobtype;
        }

        public static DataTable RefreashTable()
        {
            SqlHealper sh = new SqlHealper();
            return sh.SelectDataBase("SELECT P_ID as ID, P_Name as Name, P_Sex as Sex, P_Birthday as Birthday, P_Jobday as Jobday, P_Education as education, P_Department as department, P_Duty as duty, P_Jobtype as jobtype FROM tbl_P");
        }

        public bool add()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD(
                    "INSERT INTO tbl_P(" +
                    "P_ID , P_Name , P_Sex , P_Birthday , P_Jobday , P_Education , P_Department , P_Duty , P_Jobtype " +
                    ")values(" +
                    "'" + this.ID + "','" + this.Name + "','" + this.Sex + "','" + this.Birthday.ToShortDateString() + "','" + this.Jobday.ToShortDateString() + "','" + this.Education + "','" + this.Department + "','" + this.Duty + "','" + this.Jobtype + "'" +
                    ")"
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
            DataTable dt =  sh.SelectDataBase("select P_index from tbl_P where P_ID='"+this.ID+"'");
            this.index =  Convert.ToInt32(dt.Rows[0]["P_index"].ToString());
            return;
        }

        public bool update_by_index()
        {
            try
            {
                SqlHealper sh = new SqlHealper();
                sh.ExecuteCMD("update tbl_P  set P_ID = '" + this.ID + "',P_Name = '" + this.Name + "',P_Sex = '" + this.Sex + "',P_Birthday = '" + this.Birthday.ToShortDateString() + "',P_Jobday = '" + this.Jobday.ToShortDateString() + "',P_Education = '" + this.Education + "',P_Department = '" + this.Department + "',P_Duty = '" + this.Duty + "',P_Jobtype = '" + this.Jobtype + "' where P_index = " + this.index.ToString());

            }
            catch {
                return false;
            }
            return true;
        }

        public void delete_by_index()
        {
            SqlHealper sh = new SqlHealper();
            sh.ExecuteCMD("delete tbl_P where P_index = " + this.index.ToString());
        }

        public static DataTable search(string field,string key)
        {
            SqlHealper sh = new SqlHealper();
            return sh.SelectDataBase("SELECT P_ID as ID, P_Name as Name, P_Sex as Sex, P_Birthday as Birthday, P_Jobday as Jobday, P_Education as education, P_Department as department, P_Duty as duty, P_Jobtype as jobtype FROM tbl_P where " + field + " like '%"+key+"%'");
        }
    }
}
