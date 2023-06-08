using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.уПDataSet.Tovar); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private System.Windows.Forms.DataGridViewColumn col;

        private void button1_Click(object sender, EventArgs e)
        {
            col = new System.Windows.Forms.DataGridViewColumn();
            switch(listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn6; 
                    break;
            }

            if (radioButton1.Checked)
                tovarDataGridView.Sort(col,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                tovarDataGridView.Sort(col,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(var i =0; i < tovarDataGridView.RowCount; i++)
            {
                if(comboBox1.SelectedIndex == i)
                    tovarBindingSource1.Filter = $"Vid LIKE '%{comboBox1.Text}%'";
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tovarBindingSource1.Filter = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tovarBindingSource1.Filter = $"Nazvanie LIKE '%{textBox1.Text}%'";
        }

        private Form1 f1;
        private void button3_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }
    }
}
