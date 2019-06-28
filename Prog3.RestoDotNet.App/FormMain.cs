using Prog3.RestoDotNet.App.XmlObjects;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog3.RestoDotNet.App
{
    public partial class FormMain : Form
    {
        private readonly IOrderSvc _orderSvc;
        private readonly ITableSvc _tableSvc;
        private OpenFileDialog openFile;
        private List<TableDto> tableObjs;

        public FormMain(IOrderSvc orderSvc, ITableSvc tableSvc)
        {
            InitializeComponent();
            _orderSvc = orderSvc;
            _tableSvc = tableSvc;
        }

        private async Task GetRelatedTables(Guid trackId)
        {
            var svcResp = await _tableSvc.GetAllByTrackId(trackId);

            tableObjs = svcResp.Data.ToList();
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

        private async void BtnMapLoad_Click(object sender, EventArgs e)
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

            //cargar mesas correspondientes al mapa
            await GetRelatedTables(xmlTables.First().TackId);

            foreach (XmlTable item in xmlTables)
            {

                MoveableObject temp = tableObjs.Any(t => t.MoveableTableId == item.Id)
                    ? new MoveableTable { BindedEntity = tableObjs.First(t => t.MoveableTableId == item.Id),
                        ContextMenuStrip = cMenuStripMapLoad } : new MoveableObject();

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

                var dir = Directory.CreateDirectory($@"{Environment.CurrentDirectory}/Imagenes");
                var imgPath = $@"{dir.FullName}/{item.imageFile}";
                temp.Image = Image.FromFile(imgPath);

                this.PnlMapLoad.Controls.Add(temp);
            }

            file.Close();
        }

        private void VerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (sender as ToolStripItem);
            if (item != null)
            {
                ContextMenuStrip owner = item.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    new FormTableStatus((MoveableTable)owner.SourceControl, _orderSvc).ShowDialog();
                }
            }

        }
    }
}
