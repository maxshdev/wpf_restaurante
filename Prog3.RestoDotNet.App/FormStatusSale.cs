using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public partial class FormStatusSale : Form
    {

        public double price = 0;

        public FormStatusSale()
        {
            InitializeComponent();

            this.lbl_importe.Text = price.ToString();
        }

        private void FormStatusSale_Load(object sender, EventArgs e)
        {

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
