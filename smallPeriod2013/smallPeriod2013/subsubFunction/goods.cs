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
    public partial class goods : UserControl
    {
        SystemSession session;
        public goods(SystemSession ss)
        {
            this.session = ss;
            InitializeComponent();
        }

        private void goods_Load(object sender, EventArgs e)
        {
            this.refreash_grid();
        }

        private void refreash_grid()
        {
            this.dgv.DataSource = MMM.refreash_table();
        }

        public MMM get_goods()
        {
            return new MMM(
                tb_id.Text,
                tb_classify.Text,
                Convert.ToDouble(tb_makePrice.Text),
                Convert.ToDouble(tb_sellprice.Text),
                tb_unit.Text,
                tb_memo.Text
                );

        }

        public void set_goods(MMM m)
        { 
                tb_id.Text = m.ID;
                tb_classify.Text = m.Classify;
                tb_makePrice.Text = m.MakePrice.ToString();
                tb_sellprice.Text = m.SellPrice.ToString();
                tb_unit.Text = m.Unit;
                tb_memo.Text = m.Memo;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool res = get_goods().add();
            if (res == false)
            {
                MessageBox.Show("data Wrong");
            }
            this.refreash_grid();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            MMM m = new MMM(
                d.Rows[e.RowIndex].Cells[0].Value.ToString(),
                d.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Convert.ToDouble(d.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Convert.ToDouble(d.Rows[e.RowIndex].Cells[3].Value.ToString()),
                d.Rows[e.RowIndex].Cells[4].Value.ToString(),
                d.Rows[e.RowIndex].Cells[5].Value.ToString()
                );
            m.update_index();
            this.set_goods(m);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MMM m =get_goods();
            m.update_index();
            bool res =  m.update_by_index();
            if (res == false)
            {
                MessageBox.Show("data error");
            }
            this.refreash_grid();
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            MMM m = new MMM(
                d.Rows[e.RowIndex].Cells[0].Value.ToString(),
                d.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Convert.ToDouble(d.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Convert.ToDouble(d.Rows[e.RowIndex].Cells[3].Value.ToString()),
                d.Rows[e.RowIndex].Cells[4].Value.ToString(),
                d.Rows[e.RowIndex].Cells[5].Value.ToString()
                );
            m.update_index();
            m.delete_by_index();
            this.refreash_grid();
        }


    }
}
