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
            _currentOrder = new OrderDto { Table = tableObj.BoundedEntity };
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
                btnCloseTable.Enabled = true;

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
                    row.DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        SelectionBackColor = Color.Transparent,
                        SelectionForeColor = Color.Black,
                        BackColor = Color.LightGray
                    };
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
                new MealDto(-4, "Ravioles", 130),
                new MealDto(-5, "Parrillada", 400)
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

        private void EnableAcceptButtonIfCan()
        {
            btnSaveTableState.Enabled = !string.IsNullOrEmpty(tBoxDescription.Text)
                && mealDtoBindingSource.List.Cast<MealDto>().Count(m => m.Id < 0) > 0 //if has at least 1 food added
                && CmbMesero.SelectedItem != null;
        }

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
            if (cBoxReserved.Checked)
            {
                await _orderSvc.SetReservationAndGetOrderIdAsync(_currentOrder.Table);
            }
            else
            {
                _currentOrder.Meals = mealDtoBindingSource.List.Cast<MealDto>().ToList();
                _currentOrder.Waiter = CmbMesero.SelectedItem as WaiterDto;
                _currentOrder.Table.Caption = tBoxDescription.Text;
                _currentOrder.Obs = rTBoxNotes.Text;
                _currentOrder.DateFrom = DateTime.Now;

                var svcRes = await _orderSvc.SaveOrderAsync(_currentOrder);

                if (svcRes.HasError)
                {
                    MessageBox.Show(string.Join(",", svcRes.Errors));
                    return;
                }
            }

            Close();
        }

        private void CmbMesero_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableAcceptButtonIfCan();
        }

        private void CBoxReserved_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = ((CheckBox)sender).Checked;
            dTPickerReserved.Enabled = checkbox;
            groupBox1.Enabled = !checkbox;
            btnSaveTableState.Enabled = checkbox;
        }

        private async void BtnCloseTable_Click(object sender, EventArgs e)
        {
            var svcRes = await _orderSvc.CloseOrderAndGetTotalPriceAsync(_currentOrder);

            if (svcRes.HasError)
            {
                MessageBox.Show(string.Join(",", svcRes.Errors));
                return;
            }

            FormStatusSale status = new FormStatusSale(svcRes.Data.ToString("C"));
            status.ShowDialog();

            Close();
        }
    }
}
