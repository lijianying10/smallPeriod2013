using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace sp_DAL
{
    public static class XmlReader
    {
        public static void Read(ref string Domain, ref string user, ref string passwd , ref string DataBase)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(@"c:\documents and settings\1\my documents\visual studio 2010\Projects\smallPeriod2013\DataBaseParameter.xml");
            XmlNode xn = xd.SelectSingleNode("DB");

            XmlNode Do = xn.SelectSingleNode("Domain");
            Domain = Do.InnerText;

            XmlNode usr = xn.SelectSingleNode("User");
            user = usr.InnerText;

            XmlNode pwd = xn.SelectSingleNode("Passwd");
            passwd = pwd.InnerText;

            XmlNode db = xn.SelectSingleNode("DataBase");
            DataBase = db.InnerText;
        }
    }
}
