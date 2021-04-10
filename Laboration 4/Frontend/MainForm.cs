﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_4
{
    public partial class MainForm : Form
    {
        //Data sourses for the progam
        BindingSource _inventoryBindingSource;
        BindingSource _saleHistoryBindingSource;
        BindingSource _basketBindingSource;
        Control _control = new Control();

        public MainForm()
        {
            InitializeComponent();

        }

        public BindingSource inventoryBindingSource()
        {
            //Conect ManageInventoryControl to Contol class and get binding source
            _inventoryBindingSource = _control.LoadInventory();

            return _inventoryBindingSource;
        }

        public BindingSource basketBindingSource()
        {
            //Conect ManageInventoryControl to Contol class and get binding source
            _basketBindingSource = _control.LoadBasket();

            return _basketBindingSource;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _inventoryBindingSource = _control.LoadInventory();
                _saleHistoryBindingSource = _control.LoadSaleHistory();
                _basketBindingSource = _control.LoadBasket();
            }
            catch (Exception error)
            {
                //Show message that tells user file is not availebled
                MessageBox.Show(
                                $"{error.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Close the program
                Application.Exit();
            }

            ManageInventoryControl inventory = new ManageInventoryControl(_control, _inventoryBindingSource);
            inventory.Dock = DockStyle.Fill;
            InventoryTab.Controls.Add(inventory);

            ManageCheckoutControl checkout = new ManageCheckoutControl(_control, _inventoryBindingSource, _basketBindingSource);
            checkout.Dock = DockStyle.Fill;
            CheckoutTab.Controls.Add(checkout);

            ManageDeliveryControl delivery = new ManageDeliveryControl(_control);
            delivery.Dock = DockStyle.Fill;
            deliveryTab.Controls.Add(delivery);

            ManageStatisticsControl statistics = new ManageStatisticsControl(_control);
            statistics.Dock = DockStyle.Fill;
            StatisticsTab.Controls.Add(statistics);
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _control.Save();
        }
    }
}
