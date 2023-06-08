using System;
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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.PopularnyeTovary". При необходимости она может быть перемещена или удалена.
            this.popularnyeTovaryTableAdapter.Fill(this.уПDataSet.PopularnyeTovary);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Pribyl". При необходимости она может быть перемещена или удалена.
            this.pribylTableAdapter.Fill(this.уПDataSet.Pribyl);

        }

        private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }
    }
}
