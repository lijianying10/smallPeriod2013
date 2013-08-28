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
    public partial class login : Form
    {
        public SystemSession session;
        private int login_times;

        public login(SystemSession ss)
        {
            InitializeComponent();
            this.login_times = 0;
            this.session = ss;
        }

        private void login_Load(object sender, EventArgs e)
        {
            tb_pwd.PasswordChar = '*';
            this.ControlBox = false; 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            key k = new key(this.tb_user.Text, this.tb_pwd.Text);
            bool res = k.judge();//return a bool number
            if (res == true)
            {
                this.session.login = true;
                this.session.loginevent(this.tb_user.Text);
                MessageBox.Show("login success");
                this.Close();
            }
            else
            {
                this.login_times++;
                MessageBox.Show("user name or passwd wrong!");
            }

            if (this.login_times >= 3)
            {
                MessageBox.Show("wrong password more than 3 times login failed! \n the program will be close");
                Application.Exit();
            }
        }

    }
}
