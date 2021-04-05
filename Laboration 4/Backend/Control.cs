﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laboration_4
{
    public class Control
    {
        private Inventory _inventory;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public Control()
        {
            _inventory = new Inventory();
        }

        public Control(Inventory inventory)
        {
            _inventory = inventory;
        }


        public void Purchase()
        {
            //TODO
        }
        public void Return()
        {
            //TODO
        }

        public void Delivery()
        {
            //TODO
        }

        public void Search()
        {
            //TODO
        }

        public void NewProduct()
        {
            //TODO
        }

        public void RemoveProduct()
        {
            //TODO
        }
        public BindingSource LoadInventory()
        {
            return _inventory.InventoryLoad();
        }

    }
}