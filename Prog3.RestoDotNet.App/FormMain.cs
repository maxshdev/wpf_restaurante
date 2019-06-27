using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.App.XmlObjects;
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
using System.Xml.Serialization;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMain : Form
    {
        private readonly IOrderSvc _orderSvc;
        private readonly ITableSvc _tableSvc;

        public FormMain(IOrderSvc orderSvc, ITableSvc tableSvc)
        {
            InitializeComponent();
            _orderSvc = orderSvc;
            _tableSvc = tableSvc;
        }

        private void BtnMapEdit_Click(object sender, EventArgs e)
        {
            var dialogReult = (new FormMapEdition(_tableSvc)).ShowDialog();
        }

        private void BtnMapLoad_Click(object sender, EventArgs e)
        {

            XmlSerializer reader = new XmlSerializer(typeof(List<XmlTable>));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//XmlTables.xml";

            StreamReader file = new StreamReader(path);
            var xmlTables = (List<XmlTable>)reader.Deserialize(file);

            foreach (XmlTable item in xmlTables)
            {
                PictureBox temp = new PictureBox();
                //temp.Bottom = item.Bottom;
                temp.Height = item.Height;
                temp.Width = item.Width;
                temp.Left = item.Left;
                temp.Top = item.Top;
                Point loc = new Point();
                loc.X = item.X;
                loc.Y = item.Y;
                temp.Location = loc;

                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + item.imageFile;
                //path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//table_13189358.jpg"; // TEST
                temp.Image = Image.FromFile(path);

                temp.SizeMode = PictureBoxSizeMode.StretchImage;

                this.PnlMapLoad.Controls.Add(temp);
            }

            file.Close();
        }
    }
}
