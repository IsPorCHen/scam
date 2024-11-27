using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scaMarketPlays
{
    public partial class SalemanForm : Form
    {
        public SalemanForm()
        {
            InitializeComponent();
            Panel panel = new Panel();
            panel.BackColor = Color.Black;
            Panel panel2 = new Panel();
            panel2.BackColor = Color.Blue;
            flowLayoutPanel1.Controls.Add(panel);
            flowLayoutPanel1.Controls.Add(panel2);
        }

        private void addproduct_Click(object sender, EventArgs e)
        {

        }
    }
}
