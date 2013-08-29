using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smallPeriod2013.SubFunction
{
    public partial class goodsManage : UserControl
    {
        public SystemSession session;
        public goodsManage(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }

        private void btn_refreash_Click(object sender, EventArgs e)
        {
            if (this.session.User.Limit != 1)
            {
                MessageBox.Show("OP limited click find or exit program");
            }
            else
            {
                this.session.MainForm.Function_add_control(new subsubFunction.goods(this.session));
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            this.session.MainForm.Function_add_control(new subsubFunction.goodsFind(this.session));
        }
    }
}
