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
    public partial class goodsFind : UserControl
    {
        SystemSession session;
        public goodsFind(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }
        private void databind()
        {
            //M_ID, M_Classify, M_MakePrice, M_SellPrice, M_Unit, M_Memo
            DataTable DT = new DataTable();
            DT.Columns.Add("Value");
            DT.Columns.Add("Name");
            DataRow dr;

            dr = DT.NewRow();
            dr[0] = " "; dr[1] = " ";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_ID"; dr[1] = "ID";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_Classify"; dr[1] = "Classify";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_MakePrice"; dr[1] = "MakePrice";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_SellPrice"; dr[1] = "SellPrice";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_Unit"; dr[1] = "Unit";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "M_Memo"; dr[1] = "Memo";
            DT.Rows.Add(dr);

            cb_type.ValueMember = "Value";
            cb_type.DisplayMember = "Name";
            cb_type.DataSource = DT;
        }

        private void goodsFind_Load(object sender, EventArgs e)
        {
            this.databind();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_input.Text == "")
            {
                MessageBox.Show("Error input");
                return;
            }
            this.dataGridView1.DataSource = MMM.search(this.cb_type.SelectedValue.ToString(), this.tb_input.Text);
        }
    }
}
