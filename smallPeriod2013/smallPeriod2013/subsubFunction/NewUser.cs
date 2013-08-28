using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SP_BLL;

namespace smallPeriod2013.subsubFunction
{
    public partial class NewUser : UserControl
    {
        SystemSession session;
        public NewUser(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }

        public void dgv_refreash()
        {
            this.dgv_u.DataSource = user.get_user_table();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            this.dgv_refreash();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool res = get_user().add();
            if (res == false)
            {
                MessageBox.Show("ID wrong");
            }
            this.dgv_refreash();
        }

        private user get_user()
        {
            return new user(this.tb_id.Text, this.tb_name.Text, this.tb_pwd.Text, Convert.ToInt32(this.tb_role.Text),Convert.ToInt32(this.tb_limit.Text));
        }

        private void set_user(user u)
        {
            this.tb_id.Text = u.ID;
            this.tb_name.Text = u.Name;
            this.tb_pwd.Text = u.Pwd;
            this.tb_role.Text = u.Role.ToString();
            this.tb_limit.Text = u.Limit.ToString();
        }

        private void dgv_u_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            user.delete_by_index(d.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.dgv_refreash();
        }

        private void dgv_u_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            user u = new user(
                d.Rows[e.RowIndex].Cells[1].Value.ToString(),
                d.Rows[e.RowIndex].Cells[2].Value.ToString(),
                d.Rows[e.RowIndex].Cells[3].Value.ToString(),
                Convert.ToInt32(d.Rows[e.RowIndex].Cells[4].Value.ToString()) ,
                Convert.ToInt32(d.Rows[e.RowIndex].Cells[5].Value.ToString()) 
                );
            this.set_user(u);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            user u = this.get_user();
            u.update_index();
            u.update_by_index();
            this.dgv_refreash();
        }
    }
}
