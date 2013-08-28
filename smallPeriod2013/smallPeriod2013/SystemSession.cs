using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_BLL;
using smallPeriod2013;
using System.Windows.Forms;


namespace smallPeriod2013
{
    public class SystemSession
    {
        public bool login;
        public user User;
        public Form1 MainForm;

        public SystemSession()
        {
            this.login = false;
            this.User = new user();
        }
        public void loginevent(string uid)
        {
            this.User.initial_from_ID(uid);
        }
    }
}
