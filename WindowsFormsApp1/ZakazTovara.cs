﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZakazTovara : Form
    {
        public ZakazTovara()
        {
            InitializeComponent();
        }

        private void tovarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уПDataSet);

        }

        private void ZakazTovara_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.уПDataSet.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.tovarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уПDataSet);
        }

        private Form1 f1;
        private void button2_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tovarBindingSource.AddNew();
        }
    }
}
