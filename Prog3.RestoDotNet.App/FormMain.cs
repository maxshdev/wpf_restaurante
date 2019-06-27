using Prog3.RestoDotNet.Business.Services.Contracts;
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
            // AQUI DEBERIAMOS CARGAR EL MAPA EN MODO LECTURA. CREO QUE SERIA EN OTRO FORM
            /*
            XmlSerializer xs = new XmlSerializer(typeof(CustomerData));
            using (FileStream fs = new FileStream("MapEdition.xml", FileMode.Open))
            {
                // This will read the XML from the file and create the new instance
                // of CustomerData
                customer = xs.Deserialize(fs) as CustomerData;
            }
            */
        }
    }
}
