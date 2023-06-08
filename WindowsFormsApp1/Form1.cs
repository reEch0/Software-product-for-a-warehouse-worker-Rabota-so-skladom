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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Tovar tvr;
        private void button1_Click(object sender, EventArgs e)
        {
            tvr = new Tovar();
            tvr.Visible=true;
            this.Hide();
        }

        private ZakazTovara zt;

        private void button2_Click(object sender, EventArgs e)
        {
            zt = new ZakazTovara();
            zt.Visible=true;
            this.Hide();
        }

        private Otchet ot;
        private void button3_Click(object sender, EventArgs e)
        {
            ot = new Otchet();
            ot.Visible=true;
            this.Hide();
        }
    }
}
