using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
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
            cBoxState.DataSource = Enum.GetValues(typeof(TableStateEnum));
            _currentOrder = new OrderDto { Table = tableObj.BindedEntity };
            LoadStockMeals();
            LoadTableDetail();
            this.LoadImage(tableObj);
            _orderSvc = orderSvc;
        }

        private void LoadTableDetail()
        {
            tBoxID.Text = _currentOrder.Table.MoveableTableId.ToString();
            tBoxChair.Text = _currentOrder.Table.MaxChairs.ToString();
            tBoxDescription.Text = _currentOrder.Table.Caption;
            cBoxState.SelectedItem = _currentOrder.Table.State;
        }

        private void LoadStockMeals()
        {
            _stockMeals = new List<MealDto>
            {
                new MealDto(1, "Fideos", 65),
                new MealDto(2, "Milanesas", 150),
                new MealDto(3, "Pizza", 250),
            };

            CmbComidas.DataSource = _stockMeals;
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

        private void BtnDeletedMeal_Click(object sender, EventArgs e)
        {
            mealDtoBindingSource.RemoveCurrent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            mealDtoBindingSource.Add(CmbComidas.SelectedItem);
        }
    }
}
