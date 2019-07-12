using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Unity;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMain : Form
    {
        private readonly IUnityContainer _container;
        private readonly IOrderSvc _orderSvc;
        private readonly ITableSvc _tableSvc;
        private OpenFileDialog openFile;
        private List<TableDto> tableObjs;
        private Guid currentTrackId;

        public FormMain(IUnityContainer container)
        {
            InitializeComponent();
            _orderSvc = container.Resolve<IOrderSvc>();
            _tableSvc = container.Resolve<ITableSvc>();
            _container = container;
        }

        private void RetrieveRelatedTables(Guid trackId)
        {
            var svcResp = _tableSvc.GetAllByTrackId(trackId);

            if (svcResp.HasError)
                MessageBox.Show(string.Join(",", svcResp.Errors));
            else
                tableObjs = svcResp.Data.ToList();
        }

        private void UpdateTableImages()
        {
            foreach (MoveableTable item in PnlMapLoad.Controls.OfType<MoveableTable>())
            {

                if (item.BoundedEntity.State == TableStateEnum.DISPONIBLE && item.BoundedEntity.Shape == TableShapeEnum.SQUARE)
                {
                    item.Image = Properties.Resources.table_x2_1;
                }
                else if (item.BoundedEntity.State == TableStateEnum.DISPONIBLE && item.BoundedEntity.Shape == TableShapeEnum.RECTANGLE)
                {
                    item.Image = Properties.Resources.table_x4_1;
                }
                else if (item.BoundedEntity.State == TableStateEnum.DISPONIBLE && item.BoundedEntity.Shape == TableShapeEnum.CIRCLE)
                {
                    item.Image = Properties.Resources.table_x1_1;
                }
                else if (item.BoundedEntity.State == TableStateEnum.OCUPADO && item.BoundedEntity.Shape == TableShapeEnum.SQUARE)
                {
                    item.Image = Properties.Resources.table_x2_2;
                }
                else if (item.BoundedEntity.State == TableStateEnum.OCUPADO && item.BoundedEntity.Shape == TableShapeEnum.RECTANGLE)
                {
                    item.Image = Properties.Resources.table_x4_2;
                }
                else if (item.BoundedEntity.State == TableStateEnum.OCUPADO && item.BoundedEntity.Shape == TableShapeEnum.CIRCLE)
                {
                    item.Image = Properties.Resources.table_x1_2;
                }
                else if (item.BoundedEntity.State == TableStateEnum.RESERVADO && item.BoundedEntity.Shape == TableShapeEnum.SQUARE)
                {
                    item.Image = Properties.Resources.table_x2_3;
                }
                else if (item.BoundedEntity.State == TableStateEnum.RESERVADO && item.BoundedEntity.Shape == TableShapeEnum.RECTANGLE)
                {
                    item.Image = Properties.Resources.table_x4_3;
                }
                else if (item.BoundedEntity.State == TableStateEnum.RESERVADO && item.BoundedEntity.Shape == TableShapeEnum.CIRCLE)
                {
                    item.Image = Properties.Resources.table_x1_3;
                }
            }
        }

        private void LoadXmlMap(string xmlMapPath)
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<XmlTable>));
            StreamReader file = new StreamReader(xmlMapPath);
            var xmlTables = (List<XmlTable>)reader.Deserialize(file);

            //cargar mesas correspondientes al mapa
            currentTrackId = xmlTables.First().TackId;
            RetrieveRelatedTables(currentTrackId);

            foreach (XmlTable item in xmlTables)
            {
                MoveableObject temp;
                if (tableObjs.Any(t => t.MoveableTableId == item.Id))
                {
                    temp = new MoveableTable
                    {
                        BoundedEntity = tableObjs.Single(t => t.MoveableTableId == item.Id),
                        ContextMenuStrip = cMenuStripMapLoad
                    };
                    var table = ((MoveableTable)temp).BoundedEntity;
                    var tooltip = new ToolTip() { ShowAlways = true };
                    tooltip.SetToolTip(temp, $"{table.Caption} - {table.State}");
                }
                else
                    temp = new MoveableObject();

                temp.Id = item.Id;
                temp.Height = item.Height;
                temp.Width = item.Width;
                temp.Left = item.Left;
                temp.Top = item.Top;
                Point loc = new Point();
                loc.X = item.X;
                loc.Y = item.Y;
                temp.Location = loc;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                temp.BackColor = Color.Transparent;

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var imgPath = $@"{dir.FullName}/{item.imageFile}";
                temp.Image = Image.FromFile(imgPath);

                if (temp is MoveableTable)
                    temp.DoubleClick += Table_OnDoubleClick;

                PnlMapLoad.Controls.Add(temp);
            }

            file.Close();
            PnlMapLoad.Visible = PnlMapLoad.Controls.Count > 0;
        }

        private void CargarMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PnlMapLoad.Controls.Count > 0)
            {
                PnlMapLoad.Controls.Clear();
                tableObjs = null;
                openFile = null;
                currentTrackId = Guid.Empty;
            }

            openFile = new OpenFileDialog();
            openFile.InitialDirectory = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Mapas").FullName;
            openFile.Multiselect = false;
            openFile.Filter = "|*.xml";
            openFile.ShowHelp = false;

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            Cursor.Current = Cursors.WaitCursor;//TODO: cambiar por un spinner
            LoadXmlMap(openFile.FileName);
            UpdateTableImages();
            Cursor.Current = Cursors.Arrow;
        }

        private void Table_OnDoubleClick(object sender, EventArgs e)
        {
            OpenStatusTableForm((MoveableTable)sender);
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    OpenStatusTableForm((MoveableTable)owner.SourceControl);
                }
            }
        }

        private void OpenStatusTableForm(MoveableTable tableObj)
        {
            _container.RegisterInstance(tableObj);
            _container.Resolve<FormTableStatus>().ShowDialog();
            LoadXmlMap(openFile.FileName);
            UpdateTableImages();
        }

        private void CrearMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormMapEdition>().ShowDialog();
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            UpdateTableImages();
        }
    }
}
