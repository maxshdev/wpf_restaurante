﻿using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.App.Custom_Items;
using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMapEdition : Form
    {

        MoveableTable moveableItem;
        int cont = 0;
        private bool isPressedDown = false;
        Point initial;

        private readonly ITableSvc _tableSvc;

        public FormMapEdition(ITableSvc tableSvc)
        {
            InitializeComponent();
            _tableSvc = tableSvc;
        }

        private void SetAsMoveable()
        {

            // WHERE SPECIFIC CONTROL IN "FORM"
            // this.Controls.OfType<Control>().Where(ctr => ctr is Button).ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN "FORM"
            // this.Controls.OfType<Control>().ToList().ForEach(ctr =>
            // SIMPLE ALL CONTROLS IN CONTAINER CONTROL IN "FORM"
            // this.groupBox1.Controls.OfType<Control>().ToList().ForEach(ctr =>

            //this.PnlMap.Controls
            //    .OfType<MoveableTable>()
            //    //.Where(ctr => ctr is MoveableTable)
            //    .ToList()
            //    .ForEach(ctr =>
            //        {
            //            ctr.MouseDown += Ctr_MouseDown;
            //            ctr.MouseUp += Ctr_MouseUp;
            //            ctr.MouseMove += Ctr_MouseMove;
            //        }
            //    )
            //;

            if (moveableItem != null)
            {
                moveableItem.MouseDown += Ctr_MouseDown;
                moveableItem.MouseUp += Ctr_MouseUp;
                moveableItem.MouseMove += Ctr_MouseMove;
            }
        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (isPressedDown)
            {
                ctr.Top += e.Y - initial.Y;
                ctr.Left += e.X - initial.X;
                // ctr.Left = e.X + ctr.Left - initial.X;
                // ctr.Top = e.Y + ctr.Top - initial.Y;
            }

        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) => isPressedDown = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressedDown = true;
                initial = e.Location;
            }
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveableItem = CreateMoveableTable(sender as ReferenceTable);
                moveableItem.Left = 300;
                moveableItem.Top = 300;
                moveableItem.Width = 90;
                moveableItem.Height = 90;
                moveableItem.SizeMode = PictureBoxSizeMode.StretchImage;

                moveableItem.ContextMenuStrip = this.cmenuStripTable;

                this.PnlMap.Controls.Add(moveableItem);
                this.SetAsMoveable();
            }
        }

        private MoveableTable CreateMoveableTable(ReferenceTable ctr)
        {
            cont++;

            var mvtb = new MoveableTable
            {
                Image = ctr.Image,
                Location = ctr.Location,
                Name = "temp",
                Size = ctr.Size
            };

            mvtb.BindedEntity = new TableDto
                (
                id: cont,
                description: $"Mesa {cont}",
                state: TableStateEnum.AVAILABLE,
                shape: ctr.Shape,
                maxChairs: ctr.Shape.GetId<byte>()
                );

            return mvtb;
        }

        private void FijarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    this.PnlMap.Controls.Remove(owner.SourceControl);
                }
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //TODO: al presionar guardar llenar esta lista con las mesas creadas luego de ediar el mapa
            var tableList = new List<TableDto>();

            var xmlPanel = new XmlPanel();
            var xmlTables = new List<XmlTable>();

            List<Control> controlsPictureBox = this.PnlMap.Controls.OfType<MoveableTable>().Cast<Control>().ToList();

            foreach (MoveableTable item in controlsPictureBox)
            {
                // obtengo los valores ui del pictureBox.
                var bounds = item.Bounds;
                // voy a crear un objeto tipo tabla para poder guardar
                // las propiedades y serializarlo luego en un archivo xml.
                XmlTable xTable = new XmlTable();

                xTable.Id = item.GetHashCode();
                xTable.Bottom = bounds.Bottom;
                xTable.Height = bounds.Height;
                xTable.Width = bounds.Width;
                xTable.Left = bounds.Left;
                xTable.Top = bounds.Top;
                xTable.X = bounds.X;
                xTable.Y = bounds.Y;
                xTable.imageFile = "table_" + item.GetHashCode().ToString() + ".png";

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + xTable.imageFile;
                item.Image.Save(path, ImageFormat.Png);

                xmlTables.Add(xTable);

                tableList.Add(item.BindedEntity);
            }

            var svcResp = await _tableSvc.SetInitialTableArrangementAsync(tableList);

            if (svcResp.HasError)
            {
                //TODO tratar error
            }

            if (svcResp.Data)
            {
                //TODO: guardar antes el mapa
                XmlSerializer writer = new XmlSerializer(typeof(List<XmlTable>));

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//XmlTables.xml";
                FileStream file = File.Create(path);

                writer.Serialize(file, xmlTables);
                file.Close();

                // por objetos individuales
                /*
                XmlSerializer writer = new XmlSerializer(typeof(XmlTable));

                foreach (XmlTable item in xmlTables)
                {

                    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//XmlTable_" + item.Id.ToString() + ".xml";
                    FileStream file = File.Create(path);

                    writer.Serialize(file, item);
                }

                // USING
                using (FileStream fs = new FileStream("XmlTables.xml", FileMode.Create))
                {
                    writer.Serialize(fs, xmlTables);
                }
                */

                this.Close();
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}