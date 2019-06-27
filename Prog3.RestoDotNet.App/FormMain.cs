using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMain : Form
    {
        private readonly IOrderSvc _orderSvc;
        private readonly ITableSvc _tableSvc;
        private OpenFileDialog openFile;

        public FormMain(IOrderSvc orderSvc, ITableSvc tableSvc)
        {
            InitializeComponent();
            _orderSvc = orderSvc;
            _tableSvc = tableSvc;
        }

        private void BtnMapEdit_Click(object sender, EventArgs e)
        {
            new FormMapEdition(_tableSvc).ShowDialog();
        }

        private void BtnMapLoad_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.InitialDirectory = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Mapas").FullName;
            openFile.Multiselect = false;
            openFile.Filter = "|*.xml";
            openFile.ShowHelp = false;
            openFile.ShowDialog();
            var path = openFile.FileName;

            XmlSerializer reader = new XmlSerializer(typeof(List<XmlTable>));

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

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var imgPath = $@"{dir.FullName}/{item.imageFile}";
                temp.Image = Image.FromFile(imgPath);

                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                temp.ContextMenuStrip = this.cMenuStripMapLoad;

                this.PnlMapLoad.Controls.Add(temp);
            }

            file.Close();
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
