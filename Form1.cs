using People.DataSet_PeopleTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        private readonly DataSet_People DB_P = new DataSet_People();
        private readonly DB_Test1TableAdapter db_test1_adapter = new DB_Test1TableAdapter();
        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            db_test1_adapter.Fill(DB_P.DB_Test1);
            dataGridView1.DataSource = DB_P.DB_Test1;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var P_list = DB_P.DB_Test1.NewDB_Test1Row();
            P_list.Name = txt_name.Text;
            P_list.Address = txt_addr.Text;
            P_list.Mobile = Convert.ToDecimal(txt_mob.Text.ToString());
            P_list.email = txt_mail.Text;

            DB_P.DB_Test1.Rows.Add(P_list);
            db_test1_adapter.Update(DB_P.DB_Test1);
            DB_P.AcceptChanges();

            PopulateDataGridView();
        }
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgRow = dataGridView1.SelectedRows[0];
                int rowDt = Convert.ToInt32(dgRow.Cells["S_No"].Value);
                var rowDelete = DB_P.DB_Test1.Select($"S_No = {rowDt}");

                foreach (DataRow row in rowDelete)
                {
                    row.Delete();
                }
                db_test1_adapter.Update(DB_P.DB_Test1);
                DB_P.AcceptChanges();

                PopulateDataGridView();
            }
        }
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgRow = dataGridView1.SelectedRows[0];
                int rowIndex = dgRow.Index;

                DB_P.DB_Test1.Rows[rowIndex]["Name"] = txt_name.Text;
                DB_P.DB_Test1.Rows[rowIndex]["Address"] = txt_addr.Text;
                DB_P.DB_Test1.Rows[rowIndex]["Mobile"] = Convert.ToDecimal(txt_mob.Text.ToString());
                DB_P.DB_Test1.Rows[rowIndex]["email"] = txt_mail.Text;

                db_test1_adapter.Update(DB_P.DB_Test1);
                DB_P.AcceptChanges();

                PopulateDataGridView();
            }
        }
    }
}