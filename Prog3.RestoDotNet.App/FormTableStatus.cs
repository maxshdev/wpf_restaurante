using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
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

namespace Prog3.RestoDotNet.App
{
    public partial class FormTableStatus : Form
    {
        private readonly IOrderSvc _orderSvc;
        private IEnumerable<MealDto> _stockMeals;
        private OrderDto _currentOrder;

        public FormTableStatus()
        {
            InitializeComponent();
        }
        public FormTableStatus(MoveableTable tableObj, IOrderSvc orderSvc)
        {
            InitializeComponent();
            _currentOrder = new OrderDto();
            LoadStockMeals();
            LoadTableDetail();
            this.LoadImage(tableObj);
            _orderSvc = orderSvc;
        }

        private void LoadTableDetail()
        {
            
        }

        private void LoadStockMeals()
        {
            _stockMeals = new List<MealDto>
            {
                new MealDto(1, "Fideos", 65),
                new MealDto(2, "Milanesas", 150),
                new MealDto(3, "Pizza", 250),
            };
        }

        private void LoadImage(PictureBox temp)
        {
            pBoxImageTable.Image = temp.Image;
            pBoxImageTable.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // DETALLES DEL PEDIDO - COMIDAS

        private async void BtnAddMeals_Click(object sender, EventArgs e)
        {
            //_currentOrder.Meals.Add()
        }

        private void BtnChangeMeal_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletedMeal_Click(object sender, EventArgs e)
        {

        }

    }
}
