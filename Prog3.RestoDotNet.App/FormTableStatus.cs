using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public partial class FormTableStatus : Form
    {
        private readonly IOrderSvc _orderSvc;
        private readonly IWaiterSvc _waiterSvc;
        private IEnumerable<MealDto> _stockMeals;
        private OrderDto _currentOrder;

        public FormTableStatus(MoveableTable tableObj, IOrderSvc orderSvc, IWaiterSvc waiterSvc)
        {
            InitializeComponent();

            _orderSvc = orderSvc;
            _waiterSvc = waiterSvc;
            _currentOrder = new OrderDto { Table = tableObj.BindedEntity };
            LoadStockMeals();
            LoadAvailableWaiters();
            LoadTableDetail();
            LoadImage(tableObj);
        }

        private async void LoadTableDetail()
        {
            if (_currentOrder.Table.State == TableStateEnum.OCUPADO)
            {
                GpbReserva.Enabled = false;
                rTBoxNotes.Enabled = false;
                tBoxDescription.Enabled = false;
                CmbMesero.Enabled = false;

                var svcResp = await _orderSvc.RetrieveCurrentOpenOrderAsync(_currentOrder.Table);
                if (svcResp.HasError)
                {
                    MessageBox.Show(string.Join(",", svcResp.Errors));
                    return;
                }
                _currentOrder = svcResp.Data;
                CmbMesero.SelectedValue = _currentOrder.Waiter.Id;
                mealDtoBindingSource.DataSource = _currentOrder.Meals;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle = new DataGridViewCellStyle() { SelectionBackColor = Color.Transparent, SelectionForeColor = Color.Black, BackColor = Color.LightGray };
                }
            }

            tBoxID.Text = _currentOrder.Table.MoveableTableId.ToString();
            tBoxChair.Text = _currentOrder.Table.MaxChairs.ToString();
            tBoxDescription.Text = _currentOrder.Table.Caption;
            cBoxState.DataSource = Enum.GetValues(typeof(TableStateEnum));
            cBoxState.SelectedItem = _currentOrder.Table.State;
            rTBoxNotes.Text = _currentOrder.Obs;

        }

        private void LoadStockMeals()
        {
            _stockMeals = new List<MealDto>
            {
                new MealDto(-1, "Fideos", 65),
                new MealDto(-2, "Milanesas", 150),
                new MealDto(-3, "Pizza", 250),
            };

            CmbComidas.DataSource = _stockMeals;
            CmbComidas.SelectedItem = null;
            CmbComidas.SelectedText = "--Elija y agregue una comida--";
        }

        private async void LoadAvailableWaiters()
        {
            var svcResp = await _waiterSvc.GetAllAsync();

            if (svcResp.HasError)
            {
                MessageBox.Show(string.Join(",", svcResp.Errors));
                return;
            }

            waiterDtoBindingSource.DataSource = svcResp.Data;
            CmbMesero.SelectedItem = null;
            CmbMesero.SelectedText = "--Asigne un mesero--";

        }
        private void LoadImage(PictureBox temp)
        {
            pBoxImageTable.Image = temp.Image;
            pBoxImageTable.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // DETALLES DEL PEDIDO - COMIDAS

        private void BtnDeletedMeal_Click(object sender, EventArgs e)
        {
            if (mealDtoBindingSource.Current == null)
                return;

            var currentMeal = (MealDto)mealDtoBindingSource.Current;

            if (currentMeal.Id < 0)//TODO: redo if we retreive meals with a service
            {
                mealDtoBindingSource.RemoveCurrent();
                EnableAcceptButtonIfCan();
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CmbComidas.SelectedItem == null)
                return;

            mealDtoBindingSource.Add(CmbComidas.SelectedItem);
            CmbComidas.SelectedItem = null;
            CmbComidas.SelectedText = "--Elija y agregue una comida--";

            EnableAcceptButtonIfCan();
        }

        private async void BtnSaveTable_Click(object sender, EventArgs e)
        {
            //var list = mealDtoBindingSource.List;
            foreach (MealDto item in mealDtoBindingSource.List)
            {
                _currentOrder.Meals.Add(item);
            }

            _currentOrder.Waiter = CmbMesero.SelectedItem as WaiterDto;
            _currentOrder.Obs = rTBoxNotes.Text;
            _currentOrder.DateFrom = DateTime.Now;

            var svcRes = _orderSvc.SaveOrderAsync(_currentOrder);

            this.Close();
        }

        private void EnableAcceptButtonIfCan()
        {
            btnSaveTableState.Enabled = !string.IsNullOrEmpty(tBoxDescription.Text)
                && mealDtoBindingSource.List.Cast<MealDto>().Count(m => m.Id < 0) > 0 //if has at least 1 food added
                && CmbMesero.SelectedItem != null;
        }

        private void CmbMesero_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableAcceptButtonIfCan();
        }
    }
}
