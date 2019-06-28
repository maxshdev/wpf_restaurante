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

        MoveableObject currentObj;
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

        //private void SetAsMoveable()
        //{

        //    // WHERE SPECIFIC CONTROL IN "FORM"
        //    // this.Controls.OfType<Control>().Where(ctr => ctr is Button).ToList().ForEach(ctr =>
        //    // SIMPLE ALL CONTROLS IN "FORM"
        //    // this.Controls.OfType<Control>().ToList().ForEach(ctr =>
        //    // SIMPLE ALL CONTROLS IN CONTAINER CONTROL IN "FORM"
        //    // this.groupBox1.Controls.OfType<Control>().ToList().ForEach(ctr =>

        //    if (currentObj != null)
        //    {
        //        currentObj.MouseDown += Ctr_MouseDown;
        //        currentObj.MouseUp += Ctr_MouseUp;
        //        currentObj.MouseMove += Ctr_MouseMove;
        //    }
        //}

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (isPressedDown)
            {
                ctr.Top += e.Y - initial.Y;
                ctr.Left += e.X - initial.X;
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
                cont++;//para identificar posteriormente cada item en el mapa
                currentObj = sender is ReferenceTable ? CreateMoveableTable(sender) : CreateMoveableObj(sender);
                currentObj.Left = 100 + (10 * PnlMap.Controls.Count);//para crear en diferentes lugares
                currentObj.Top = 100 + (10 * PnlMap.Controls.Count);
                currentObj.Width = 90;
                currentObj.Height = 90;
                currentObj.SizeMode = PictureBoxSizeMode.StretchImage;
                currentObj.BackColor = Color.Transparent;
                currentObj.ContextMenuStrip = this.cmenuStripTable;

                currentObj.MouseDown += Ctr_MouseDown;
                currentObj.MouseUp += Ctr_MouseUp;
                currentObj.MouseMove += Ctr_MouseMove;

                this.PnlMap.Controls.Add(currentObj);

                this.BtnSave.Enabled = PnlMap.Controls.OfType<MoveableTable>().Count() > 0;
            }
        }

        private MoveableObject CreateMoveableObj(object obj)
        {
            var pctBx = obj as PictureBox;

            return new MoveableObject
            {
                Id = cont,
                Image = pctBx.Image,
                Location = pctBx.Location,
                Name = $"temp_{cont}",
                Size = pctBx.Size
            };
        }

        private MoveableTable CreateMoveableTable(object obj)
        {
            var refTab = obj as ReferenceTable;

            var movTb = new MoveableTable
            {
                Id = cont,
                Image = refTab.Image,
                Location = refTab.Location,
                Name = $"temp_{cont}",
                Size = refTab.Size
            };

            movTb.BindedEntity = new TableDto
                (
                caption: $"Table {cont}",
                moveableTableId: cont,
                mapTrackId: currentMapTrackId,
                state: TableStateEnum.AVAILABLE,
                shape: refTab.Shape,
                maxChairs: refTab.Shape.GetId<byte>()
                );

            return movTb;
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

            foreach (MoveableObject item in PnlMap.Controls.OfType<MoveableObject>())
            {
                // obtengo los valores ui del pictureBox.
                var bounds = item.Bounds;
                // voy a crear un objeto tipo tabla para poder guardar
                // las propiedades y serializarlo luego en un archivo xml.
                XmlTable xTable = new XmlTable();
                xTable.Id = item.Id;
                xTable.TackId = currentMapTrackId;
                xTable.Bottom = bounds.Bottom;
                xTable.Height = bounds.Height;
                xTable.Width = bounds.Width;
                xTable.Left = bounds.Left;
                xTable.Top = bounds.Top;
                xTable.X = bounds.X;
                xTable.Y = bounds.Y;
                xTable.imageFile = $"image_{item.Id}_{currentMapTrackId}.png";

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var path = $@"{dir.FullName}/{xTable.imageFile}";
                item.Image.Save(path, ImageFormat.Png);

                xmlTables.Add(xTable);

                if(item is MoveableTable)
                    tableList.Add(((MoveableTable)item).BindedEntity);
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
                var path = $@"{dir.FullName}/Mapa_{DateTime.Now.ToString("dd-MM-yyyy HH.mm.ss")}.xml";
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

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            Graphics gr = PnlMap.CreateGraphics();
            Pen pen = new Pen(Brushes.Black, 1);
            int lines = 10; // 10x10
            float x = 0f;
            float y = 0f;
            float xSpace = PnlMap.Width / lines;
            float ySpace = PnlMap.Height / lines;

            // lineas verticales
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(pen, x, y, x, PnlMap.Height);
                x += xSpace;
            }

            // lineas horizontales
            x = 0f;
            for (int i = 0; i < lines + 1; i++)
            {
                gr.DrawLine(pen, x, y, PnlMap.Width, y);
                y += ySpace;
            }
        }
    }
}
