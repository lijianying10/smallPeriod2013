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
    public partial class PersionManage : UserControl
    {
        private SystemSession session;
        public PersionManage(SystemSession ss)
        {
            InitializeComponent();
            this.session = ss;
        }

        private void PersionManage_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.session.User.Limit != 1)
            {
                MessageBox.Show("OP limited click find or exit program");
            }
            else 
            { 
                this.session.MainForm.Function_add_control(new subsubFunction.Persional(this.session));
            }
            
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.session.MainForm.Function_add_control(new subsubFunction.PersionFind(this.session));
        }
    }
}
