using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SP_BLL;

namespace smallPeriod2013
{
    public partial class Form1 : Form
    {
        public SystemSession session;
        public Form1()
        {
            this.session = new SystemSession();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login l = new login(this.session);
            l.ShowDialog();
            this.lbl_login_status.Text = "User ID: " + this.session.User.ID + " | User name: " + this.session.User.Name + " | User Power: " + this.session.User.Limit;
            this.session.MainForm = this;
            this.p_sysfunc.Controls.Clear();
            this.p_sysfunc.Controls.Add(new systemFunc(this.session));
        }

        public void Form_reload()
        {
            this.lbl_login_status.Text = "User ID: " + this.session.User.ID + " | User name: " + this.session.User.Name + " | User Power: " + this.session.User.Limit;
            this.session.MainForm = this;
            this.p_sysfunc.Controls.Clear();
            this.p_sysfunc.Controls.Add(new systemFunc(this.session));
        }

        public void SubFunction_add_control(Control Co)
        {
            this.p_subsection.Controls.Clear();
            this.p_subsection.Controls.Add(Co);
        }

        public void Function_add_control(Control co)
        {
            this.p_function.Controls.Clear();
            this.p_function.Controls.Add(co);
        }

    }
}
