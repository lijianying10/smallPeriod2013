using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smallPeriod2013
{
    public partial class systemFunc : UserControl
    {
        private SystemSession session;
        public systemFunc(SystemSession ss)
        {
            InitializeComponent();
            this.session = ss;
        }

        private void systemFunc_Load(object sender, EventArgs e)
        {
            if (this.session.User.Role == 2)
            {
                this.btn_system.Visible = false;
            }
        }

        private void btn_switch_user_Click(object sender, EventArgs e)
        {
            login l = new login(this.session);
            l.ShowDialog();
            this.session.MainForm.Form_reload();
        }

        private void btn_add_P_Click(object sender, EventArgs e)
        {
            this.session.MainForm.SubFunction_add_control(new PersionManage(this.session));
            if (this.session.User.Limit == 1)
            {
                this.session.MainForm.Function_add_control(new subsubFunction.Persional(this.session));
            }
            else
            {
                this.session.MainForm.Function_add_control(new subsubFunction.PersionFind(this.session));
            }
        }

        private void btn_system_Click(object sender, EventArgs e)
        {
            this.session.MainForm.Function_add_control(new subsubFunction.NewUser(this.session));
        }
    }
}
