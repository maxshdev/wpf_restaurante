using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_restaurante
{
    public partial class Form1 : Form
    {

        List<Button> buttons;
        bool down = false;
        Point initial;

        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttons.Add(this.btn_addTable);
            this.MovingElements();
        }

        private void MovingElements()
        {
            // WHERE SPECIFIC CONTROL IN "FORM"
            // this.Controls.OfType<Control>().Where(ctr => ctr is Button).ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN "FORM"
            // this.Controls.OfType<Control>().ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN CONTAINER CONTROL IN "FORM"
            // this.groupBox1.Controls.OfType<Control>().ToList().ForEach(ctr =>
            this.splitContainer.Panel2.Controls
                .OfType<Control>()
                .Where(ctr => ctr is Button)
                .ToList()
                .ForEach(ctr =>
                    {
                        ctr.MouseDown += Ctr_MouseDown;
                        ctr.MouseUp += Ctr_MouseUp;
                        ctr.MouseMove += Ctr_MouseMove;
                    }
                )
            ;
        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (down)
            {
                ctr.Top += e.Y - initial.Y;
                ctr.Left += e.X - initial.X;
                // ctr.Left = e.X + ctr.Left - initial.X;
                // ctr.Top = e.Y + ctr.Top - initial.Y;
            }

        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) => down = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                initial = e.Location;
            }
        }

        private void Btn_addTable_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Left = 245;
            newButton.Top = 200;
            newButton.Width = 100;
            newButton.Height = 30;
            newButton.Text = "mesa_2";
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            this.splitContainer.Panel2.Controls.Add(newButton);
            this.MovingElements();
        }
    }
}
