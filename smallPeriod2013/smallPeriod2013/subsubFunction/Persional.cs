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
    public partial class Persional : UserControl
    {

        private int Display_index;
        SystemSession session;
        public Persional(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }
        private void DataBind()
        {
            DataTable GenderDT = new DataTable();
            GenderDT.Columns.Add("Value");
            GenderDT.Columns.Add("Name");
            DataRow dr ;
            dr = GenderDT.NewRow();
            dr[0] = "";
            dr[1] = "";
            dr = GenderDT.NewRow();
            dr[0] = "男";
            dr[1] = "男";
            GenderDT.Rows.Add(dr);
            dr = GenderDT.NewRow();
            dr[0] = "女";
            dr[1] = "女";
            GenderDT.Rows.Add(dr);
            cb_gender.ValueMember = "Value";
            cb_gender.DisplayMember = "Name";
            cb_gender.DataSource = GenderDT;

            DataTable EducationDT = new DataTable();
            EducationDT.Columns.Add("Value");
            EducationDT.Columns.Add("Name");
            DataRow dr_education;
            dr_education = EducationDT.NewRow();
            dr_education[0] = " "; dr_education[1] = " ";
            dr_education = EducationDT.NewRow();
            dr_education[0] = "大学"; dr_education[1] = "大学";
            EducationDT.Rows.Add(dr_education);
            dr_education = EducationDT.NewRow();
            dr_education[0] = "硕士"; dr_education[1] = "硕士";
            EducationDT.Rows.Add(dr_education);
            dr = EducationDT.NewRow();
            dr[0] = "博士"; dr[1] = "博士";
            EducationDT.Rows.Add(dr);
            cb_education.ValueMember = "Value";
            cb_education.DisplayMember = "Name";
            cb_education.DataSource = EducationDT;

            DataTable DepartmentDT = new DataTable();
            DepartmentDT.Columns.Add("Value");
            DepartmentDT.Columns.Add("Name");
            DataRow dr_Department;
            dr_Department = DepartmentDT.NewRow();
            dr_Department[0] = " "; dr_Department[1] = " ";
            dr_Department = DepartmentDT.NewRow();
            dr_Department[0] = "普通员工"; dr_Department[1] = "普通员工";
            DepartmentDT.Rows.Add(dr_Department);
            dr_Department = DepartmentDT.NewRow();
            dr_Department[0] = "管理"; dr_Department[1] = "管理";
            DepartmentDT.Rows.Add(dr_Department);
            cb_department.ValueMember = "Value";
            cb_department.DisplayMember = "Name";
            cb_department.DataSource = DepartmentDT;
            

            DataTable DutyDT = new DataTable();
            DutyDT.Columns.Add("Value");
            DutyDT.Columns.Add("Name");
            dr = DutyDT.NewRow();
            dr[0] = " "; dr[1] = " ";
            dr = DutyDT.NewRow();
            dr[0] = "干活"; dr[1] = "干活";
            DutyDT.Rows.Add(dr);
            dr = DutyDT.NewRow();
            dr[0] = "管理"; dr[1] = "管理";
            DutyDT.Rows.Add(dr);
            cb_duty.ValueMember = "Value";
            cb_duty.DisplayMember = "Name";
            cb_duty.DataSource = DutyDT;

            DataTable JobTypeDT = new DataTable();
            cb_jobType.ValueMember = "Value";
            cb_jobType.DisplayMember = "Name";
            cb_jobType.DataSource = DutyDT;
            
            
        }

        private void refreash_grid()
        {
            this.dgv.DataSource = Persion.RefreashTable();
        }

        private void Persional_Load(object sender, EventArgs e)
        {
            this.refreash_grid();
            DataBind();
        }

        public Persion get_persion()
        {
            return new Persion(this.tb_ID.Text,this.tb_Name.Text,
                this.cb_gender.Text,
                this.dt_birthday.Value,
                this.dt_jobday.Value,
                this.cb_education.Text,
                this.cb_department.Text,
                this.cb_duty.Text,
                this.cb_jobType.Text);
        }
        public void set_Persion(Persion P)
        {
            this.tb_ID.Text = P.ID;
            this.tb_Name.Text = P.Name;
            this.cb_gender.Text = P.Sex;
            this.dt_birthday.Value = P.Birthday;
            this.dt_jobday.Value = P.Jobday;
            this.cb_education.Text = P.Education;
            this.cb_department.Text = P.Department;
            this.cb_duty.Text = P.Duty;
            this.cb_jobType.Text = P.Jobtype;
            this.Display_index = P.index;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool res = this.get_persion().add();
            this.refreash_grid();
            if (res == false)
            {
                MessageBox.Show("wrong");
            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            Persion p = new Persion(
                d.Rows[e.RowIndex].Cells[0].Value.ToString(),
                d.Rows[e.RowIndex].Cells[1].Value.ToString(),
                d.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DateTime.Parse(d.Rows[e.RowIndex].Cells[3].Value.ToString()),
                DateTime.Parse(d.Rows[e.RowIndex].Cells[4].Value.ToString()),
                d.Rows[e.RowIndex].Cells[5].Value.ToString(),
                d.Rows[e.RowIndex].Cells[6].Value.ToString(),
                d.Rows[e.RowIndex].Cells[7].Value.ToString(),
                d.Rows[e.RowIndex].Cells[8].Value.ToString()
                );
            p.update_index();
            this.set_Persion(p);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Persion P = get_persion();
            P.index = this.Display_index;
            bool res = P.update_by_index();
            if (res == false)
            {
                MessageBox.Show("data wrong");
            }
            this.refreash_grid();
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;
            Persion p = new Persion(
                d.Rows[e.RowIndex].Cells[0].Value.ToString(),
                d.Rows[e.RowIndex].Cells[1].Value.ToString(),
                d.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DateTime.Parse(d.Rows[e.RowIndex].Cells[3].Value.ToString()),
                DateTime.Parse(d.Rows[e.RowIndex].Cells[4].Value.ToString()),
                d.Rows[e.RowIndex].Cells[5].Value.ToString(),
                d.Rows[e.RowIndex].Cells[6].Value.ToString(),
                d.Rows[e.RowIndex].Cells[7].Value.ToString(),
                d.Rows[e.RowIndex].Cells[8].Value.ToString()
                );
            p.update_index();
            p.delete_by_index();
            this.refreash_grid();
        }
    }
}
