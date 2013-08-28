using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sp_DAL;
using System.Windows.Forms;

namespace test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string user="",passwd="",domain="",database="";
            XmlReader.Read(ref domain,ref  user, ref passwd,ref database);
            Console.WriteLine("user = "+user);
            Console.WriteLine("passwd = " + passwd);
            Console.WriteLine("domain = " + domain);


            SqlHealper sh = new SqlHealper();
            sh.ExecuteCMD("update tbl_P set P_Jobtype='管理' where P_ID='test1'");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.ReadLine();
        }
    }
}
