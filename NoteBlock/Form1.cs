using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBlock
{
    public partial class NoteBlock : Form
    {
        DataTable table;
        public NoteBlock()
        {
            InitializeComponent();
        }

        private void NoteBlock_Load_1(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = table;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if(index >= 0)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
