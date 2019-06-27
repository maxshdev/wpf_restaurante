using Pandora.NetStandard.Core.Utils;
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
        Guid currentMapTrackId;
        int cont = 0;

        private bool isPressedDown = false;
        Point initial;

        private readonly ITableSvc _tableSvc;

        public FormMapEdition(ITableSvc tableSvc)
        {
            InitializeComponent();
            currentMapTrackId = Guid.NewGuid();//track id diferente por cda instancia de edicion
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
                moveableItem.Left = 100 + (100 * PnlMap.Controls.Count);//para crear en diferentes lugares
                moveableItem.Top = 100 + (100 * PnlMap.Controls.Count);
                moveableItem.Width = 90;
                moveableItem.Height = 90;
                moveableItem.SizeMode = PictureBoxSizeMode.StretchImage;

                moveableItem.ContextMenuStrip = this.cmenuStripTable;

                this.PnlMap.Controls.Add(moveableItem);
                this.SetAsMoveable();
                this.BtnSave.Enabled = PnlMap.Controls.Count > 0;
            }
        }

        private MoveableTable CreateMoveableTable(ReferenceTable ctr)
        {
            cont++;

            var mvtb = new MoveableTable
            {
                Image = ctr.Image,
                Location = ctr.Location,
                Name = $"temp_{cont}",
                Size = ctr.Size
            };

            mvtb.BindedEntity = new TableDto
                (
                caption: $"Mesa {cont}",
                mapTrackId: currentMapTrackId,
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
            this.BtnSave.Enabled = PnlMap.Controls.Count > 0;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //TODO: al presionar guardar llenar esta lista con las mesas creadas luego de ediar el mapa
            var tableList = new List<TableDto>();
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
                xTable.imageFile = $"table_{item.BindedEntity.Shape}.png";

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var path = $@"{dir.FullName}/{xTable.imageFile}";
                item.Image.Save(path, ImageFormat.Png);

                xmlTables.Add(xTable);
                tableList.Add(item.BindedEntity);
            }

            var svcResp = await _tableSvc.SetInitialTableArrangementAsync(tableList);

            if (svcResp.HasError || !svcResp.Data)
            {
#if DEBUG
                MessageBox.Show(string.Join(" - ", svcResp.Errors), "Ocurrio un error");
#else
                MessageBox.Show("Ocurrio un error");
#endif

            }

            if (svcResp.Data)
            {
                //TODO: guardar antes el mapa
                XmlSerializer writer = new XmlSerializer(typeof(List<XmlTable>));

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Mapas");
                var path = $@"{dir.FullName}/Mapa_{currentMapTrackId}.xml";
                FileStream file = File.Create(path);

                writer.Serialize(file, xmlTables);
                file.Close();

                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
