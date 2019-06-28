using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public partial class FormTableStatus : Form
    {
        public FormTableStatus()
        {
            InitializeComponent();
        }
        public FormTableStatus(Control sender)
        {
            InitializeComponent();
            this.LoadImage((PictureBox)sender);
        }


        private void LoadImage(PictureBox temp)
        {
            pBoxImageTable.Image = temp.Image;
        }

        // DETALLES DEL PEDIDO - COMIDAS

        private void BtnAddMeals_Click(object sender, EventArgs e)
        {

        }

        private void BtnChangeMeal_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletedMeal_Click(object sender, EventArgs e)
        {

        }

    }
}
