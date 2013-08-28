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
    public partial class PersionFind : UserControl
    {
        public SystemSession session;
        public PersionFind(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }

        private void databind()
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("Value");
            DT.Columns.Add("Name");
            DataRow dr;

            dr = DT.NewRow();
            dr[0] = " "; dr[1] = " ";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_ID"; dr[1] = "ID";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Name"; dr[1] = "Name";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Sex"; dr[1] = "Sex";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Birthday"; dr[1] = "Birthday";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Jobday"; dr[1] = "Jobday";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Education"; dr[1] = "Education";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Department"; dr[1] = "Department";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Duty"; dr[1] = "Duty";
            DT.Rows.Add(dr);

            dr = DT.NewRow();
            dr[0] = "P_Jobtype"; dr[1] = "Jobtype";
            DT.Rows.Add(dr); 

            dr = DT.NewRow();
            dr[0] = " "; dr[1] = " ";
            DT.Rows.Add(dr);
            cb_type.ValueMember = "Value";
            cb_type.DisplayMember = "Name";
            cb_type.DataSource = DT;
        }

        private void PersionFind_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Persion.search("P_" + this.cb_type.SelectedItem.ToString(), this.tb_condation.Text);
        }
    }
}
