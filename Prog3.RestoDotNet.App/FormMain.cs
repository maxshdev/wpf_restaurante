﻿using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void UpdateState(List<XmlTable> xmlTables)
        {
            foreach (PictureBox item in PnlMapLoad.Controls.OfType<PictureBox>())
            {
                int caseSwitch = 1;

                switch (caseSwitch) // 
                {
                    case 1:
                        item.BackColor = Color.Transparent; // color blanco
                        break;
                    case 2:
                        item.BackColor = Color.Red;  // color rojo
                        break;
                    default:
                        item.BackColor = Color.Yellow; // color amarillo
                        break;
                }
            }
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

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

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
            Control temp = new Control();
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    temp = owner.SourceControl;
                }
            }

            new FormTableStatus(temp).ShowDialog();
        }
    }
}
