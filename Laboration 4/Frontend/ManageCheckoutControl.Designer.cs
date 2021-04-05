﻿
namespace Laboration_4
{
    partial class ManageCheckoutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MenuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.itemNumberSearchLabel = new System.Windows.Forms.Label();
            this.itemNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.returnRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.checkutLabel = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.basketDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).BeginInit();
            this.MenuSplitContainer.Panel1.SuspendLayout();
            this.MenuSplitContainer.Panel2.SuspendLayout();
            this.MenuSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.MenuSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.inventoryDataGridView);
            this.mainSplitContainer.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.SplitterDistance = 118;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuSplitContainer.Enabled = false;
            this.MenuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.Controls.Add(this.itemNumberSearchLabel);
            this.MenuSplitContainer.Panel1.Controls.Add(this.itemNumberSearchTextBox);
            this.MenuSplitContainer.Panel1.Controls.Add(this.returnRadioButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.radioButtonBuy);
            this.MenuSplitContainer.Panel1.Controls.Add(this.checkutLabel);
            // 
            // MenuSplitContainer.Panel2
            // 
            this.MenuSplitContainer.Panel2.Controls.Add(this.basketDataGridView);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonRemove);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonAdd);
            this.MenuSplitContainer.Panel2.Controls.Add(this.buttonBuy);
            this.MenuSplitContainer.Panel2.Controls.Add(this.cartLabel);
            this.MenuSplitContainer.Size = new System.Drawing.Size(620, 118);
            this.MenuSplitContainer.SplitterDistance = 112;
            this.MenuSplitContainer.TabIndex = 0;
            this.MenuSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.MenuSplitContainer_SplitterMoved);
            // 
            // itemNumberSearchLabel
            // 
            this.itemNumberSearchLabel.AutoSize = true;
            this.itemNumberSearchLabel.Location = new System.Drawing.Point(4, 79);
            this.itemNumberSearchLabel.Name = "itemNumberSearchLabel";
            this.itemNumberSearchLabel.Size = new System.Drawing.Size(66, 13);
            this.itemNumberSearchLabel.TabIndex = 4;
            this.itemNumberSearchLabel.Text = "Varunummer";
            // 
            // itemNumberSearchTextBox
            // 
            this.itemNumberSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNumberSearchTextBox.Location = new System.Drawing.Point(7, 95);
            this.itemNumberSearchTextBox.Name = "itemNumberSearchTextBox";
            this.itemNumberSearchTextBox.Size = new System.Drawing.Size(98, 20);
            this.itemNumberSearchTextBox.TabIndex = 3;
            // 
            // returnRadioButton
            // 
            this.returnRadioButton.AutoSize = true;
            this.returnRadioButton.Location = new System.Drawing.Point(7, 56);
            this.returnRadioButton.Name = "returnRadioButton";
            this.returnRadioButton.Size = new System.Drawing.Size(62, 17);
            this.returnRadioButton.TabIndex = 2;
            this.returnRadioButton.Text = "Återköp";
            this.returnRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Checked = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(7, 30);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBuy.TabIndex = 1;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Köp";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            // 
            // checkutLabel
            // 
            this.checkutLabel.AutoSize = true;
            this.checkutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkutLabel.Location = new System.Drawing.Point(3, 0);
            this.checkutLabel.Name = "checkutLabel";
            this.checkutLabel.Size = new System.Drawing.Size(58, 20);
            this.checkutLabel.TabIndex = 0;
            this.checkutLabel.Text = "Kassa";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuy.Location = new System.Drawing.Point(424, 90);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "Köp";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(3, 0);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(74, 17);
            this.cartLabel.TabIndex = 1;
            this.cartLabel.Text = "Varukorg";
            this.cartLabel.Click += new System.EventHandler(this.cartLabel_Click);
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AllowUserToOrderColumns = true;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.ShowCellErrors = false;
            this.inventoryDataGridView.ShowCellToolTips = false;
            this.inventoryDataGridView.ShowEditingIcon = false;
            this.inventoryDataGridView.ShowRowErrors = false;
            this.inventoryDataGridView.Size = new System.Drawing.Size(620, 264);
            this.inventoryDataGridView.TabIndex = 2;
            this.inventoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryDataGridView_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(424, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Lägg till";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(424, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Ta bort";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // basketDataGridView
            // 
            this.basketDataGridView.AllowUserToAddRows = false;
            this.basketDataGridView.AllowUserToDeleteRows = false;
            this.basketDataGridView.AllowUserToOrderColumns = true;
            this.basketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDataGridView.Location = new System.Drawing.Point(6, 25);
            this.basketDataGridView.MultiSelect = false;
            this.basketDataGridView.Name = "basketDataGridView";
            this.basketDataGridView.ReadOnly = true;
            this.basketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketDataGridView.ShowCellErrors = false;
            this.basketDataGridView.ShowCellToolTips = false;
            this.basketDataGridView.ShowEditingIcon = false;
            this.basketDataGridView.ShowRowErrors = false;
            this.basketDataGridView.Size = new System.Drawing.Size(412, 88);
            this.basketDataGridView.TabIndex = 18;
            // 
            // ManageCheckoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "ManageCheckoutControl";
            this.Size = new System.Drawing.Size(620, 386);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.MenuSplitContainer.Panel1.ResumeLayout(false);
            this.MenuSplitContainer.Panel1.PerformLayout();
            this.MenuSplitContainer.Panel2.ResumeLayout(false);
            this.MenuSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).EndInit();
            this.MenuSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer MenuSplitContainer;
        private System.Windows.Forms.Label itemNumberSearchLabel;
        private System.Windows.Forms.TextBox itemNumberSearchTextBox;
        private System.Windows.Forms.RadioButton returnRadioButton;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.Label checkutLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView basketDataGridView;
    }
}