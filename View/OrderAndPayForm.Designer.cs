﻿namespace DEUProject_CSharp_OutbackPOS.View
{
    partial class OrderAndPayForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.orderpayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.orderPaySystem = new System.Windows.Forms.TableLayoutPanel();
            this.addMenuGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltableName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTablePay = new System.Windows.Forms.Button();
            this.btnTableOrder = new System.Windows.Forms.Button();
            this.nowMenuGridView = new System.Windows.Forms.DataGridView();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSearch = new System.Windows.Forms.TableLayoutPanel();
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.comboBoxIngredientOrigin = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.메뉴삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.orderpayLayout.SuspendLayout();
            this.orderPaySystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMenuGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowMenuGridView)).BeginInit();
            this.menuSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderpayLayout, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.786364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.21364F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanelTitle
            // 
            this.tableLayoutPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.tableLayoutPanelTitle.ColumnCount = 1;
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTitle.Controls.Add(this.txtTitle, 0, 0);
            this.tableLayoutPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
            this.tableLayoutPanelTitle.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTitle.Name = "tableLayoutPanelTitle";
            this.tableLayoutPanelTitle.RowCount = 1;
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(1896, 79);
            this.tableLayoutPanelTitle.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(908, 20);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(129, 38);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "주문결제";
            // 
            // orderpayLayout
            // 
            this.orderpayLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.orderpayLayout.ColumnCount = 2;
            this.orderpayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.orderpayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderpayLayout.Controls.Add(this.orderPaySystem, 1, 0);
            this.orderpayLayout.Controls.Add(this.menuSearch, 0, 0);
            this.orderpayLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderpayLayout.Location = new System.Drawing.Point(4, 84);
            this.orderpayLayout.Name = "orderpayLayout";
            this.orderpayLayout.RowCount = 1;
            this.orderpayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderpayLayout.Size = new System.Drawing.Size(1890, 936);
            this.orderpayLayout.TabIndex = 6;
            // 
            // orderPaySystem
            // 
            this.orderPaySystem.BackColor = System.Drawing.Color.White;
            this.orderPaySystem.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.orderPaySystem.ColumnCount = 1;
            this.orderPaySystem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderPaySystem.Controls.Add(this.addMenuGridView, 0, 2);
            this.orderPaySystem.Controls.Add(this.panel1, 0, 0);
            this.orderPaySystem.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.orderPaySystem.Controls.Add(this.nowMenuGridView, 0, 1);
            this.orderPaySystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPaySystem.Location = new System.Drawing.Point(1417, 0);
            this.orderPaySystem.Margin = new System.Windows.Forms.Padding(0);
            this.orderPaySystem.Name = "orderPaySystem";
            this.orderPaySystem.RowCount = 4;
            this.orderPaySystem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.orderPaySystem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.orderPaySystem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.orderPaySystem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.orderPaySystem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderPaySystem.Size = new System.Drawing.Size(473, 936);
            this.orderPaySystem.TabIndex = 1;
            // 
            // addMenuGridView
            // 
            this.addMenuGridView.AllowUserToAddRows = false;
            this.addMenuGridView.AllowUserToResizeColumns = false;
            this.addMenuGridView.AllowUserToResizeRows = false;
            this.addMenuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addMenuGridView.BackgroundColor = System.Drawing.Color.White;
            this.addMenuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addMenuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.addMenuGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMenuGridView.Location = new System.Drawing.Point(2, 560);
            this.addMenuGridView.Margin = new System.Windows.Forms.Padding(0);
            this.addMenuGridView.Name = "addMenuGridView";
            this.addMenuGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.addMenuGridView.RowHeadersVisible = false;
            this.addMenuGridView.RowHeadersWidth = 62;
            this.addMenuGridView.RowTemplate.Height = 30;
            this.addMenuGridView.Size = new System.Drawing.Size(469, 185);
            this.addMenuGridView.TabIndex = 5;
            this.addMenuGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.addMenuGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuName";
            this.dataGridViewTextBoxColumn2.FillWeight = 350F;
            this.dataGridViewTextBoxColumn2.HeaderText = "메뉴명";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "가격";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "수량";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceSum";
            this.dataGridViewTextBoxColumn5.HeaderText = "총액";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltableName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 138);
            this.panel1.TabIndex = 0;
            // 
            // lbltableName
            // 
            this.lbltableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.lbltableName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltableName.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltableName.Location = new System.Drawing.Point(0, 0);
            this.lbltableName.Name = "lbltableName";
            this.lbltableName.Size = new System.Drawing.Size(469, 138);
            this.lbltableName.TabIndex = 4;
            this.lbltableName.Text = "lbltableName";
            this.lbltableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnTablePay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTableOrder, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 750);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 181);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnTablePay
            // 
            this.btnTablePay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTablePay.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTablePay.Location = new System.Drawing.Point(234, 15);
            this.btnTablePay.Name = "btnTablePay";
            this.btnTablePay.Size = new System.Drawing.Size(226, 150);
            this.btnTablePay.TabIndex = 1;
            this.btnTablePay.Text = "결제";
            this.btnTablePay.UseVisualStyleBackColor = true;
            this.btnTablePay.Click += new System.EventHandler(this.btnTablePay_Click);
            // 
            // btnTableOrder
            // 
            this.btnTableOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTableOrder.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTableOrder.Location = new System.Drawing.Point(3, 15);
            this.btnTableOrder.Name = "btnTableOrder";
            this.btnTableOrder.Size = new System.Drawing.Size(225, 150);
            this.btnTableOrder.TabIndex = 0;
            this.btnTableOrder.Text = "주문";
            this.btnTableOrder.UseVisualStyleBackColor = true;
            this.btnTableOrder.Click += new System.EventHandler(this.btnTableOrder_Click);
            // 
            // nowMenuGridView
            // 
            this.nowMenuGridView.AllowUserToAddRows = false;
            this.nowMenuGridView.AllowUserToResizeColumns = false;
            this.nowMenuGridView.AllowUserToResizeRows = false;
            this.nowMenuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nowMenuGridView.BackgroundColor = System.Drawing.Color.White;
            this.nowMenuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nowMenuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuID,
            this.MenuName,
            this.Price,
            this.Quantity,
            this.PriceSum});
            this.nowMenuGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowMenuGridView.Location = new System.Drawing.Point(2, 142);
            this.nowMenuGridView.Margin = new System.Windows.Forms.Padding(0);
            this.nowMenuGridView.Name = "nowMenuGridView";
            this.nowMenuGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.nowMenuGridView.RowHeadersVisible = false;
            this.nowMenuGridView.RowHeadersWidth = 62;
            this.nowMenuGridView.RowTemplate.Height = 30;
            this.nowMenuGridView.Size = new System.Drawing.Size(469, 416);
            this.nowMenuGridView.TabIndex = 4;
            this.nowMenuGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.nowMenuGridView_CellEndEdit);
            // 
            // MenuID
            // 
            this.MenuID.DataPropertyName = "MenuID";
            this.MenuID.HeaderText = "MenuID";
            this.MenuID.MinimumWidth = 8;
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            this.MenuID.Visible = false;
            // 
            // MenuName
            // 
            this.MenuName.DataPropertyName = "MenuName";
            this.MenuName.FillWeight = 350F;
            this.MenuName.HeaderText = "메뉴명";
            this.MenuName.MinimumWidth = 8;
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "가격";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "수량";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // PriceSum
            // 
            this.PriceSum.DataPropertyName = "PriceSum";
            this.PriceSum.HeaderText = "총액";
            this.PriceSum.MinimumWidth = 8;
            this.PriceSum.Name = "PriceSum";
            this.PriceSum.ReadOnly = true;
            // 
            // menuSearch
            // 
            this.menuSearch.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuSearch.ColumnCount = 1;
            this.menuSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuSearch.Controls.Add(this.menuGrid, 0, 1);
            this.menuSearch.Controls.Add(this.groupBox1, 0, 0);
            this.menuSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSearch.Location = new System.Drawing.Point(0, 0);
            this.menuSearch.Margin = new System.Windows.Forms.Padding(0);
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.RowCount = 2;
            this.menuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.menuSearch.Size = new System.Drawing.Size(1417, 936);
            this.menuSearch.TabIndex = 2;
            // 
            // menuGrid
            // 
            this.menuGrid.AllowUserToResizeColumns = false;
            this.menuGrid.AllowUserToResizeRows = false;
            this.menuGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGrid.Location = new System.Drawing.Point(1, 141);
            this.menuGrid.Margin = new System.Windows.Forms.Padding(0);
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.ReadOnly = true;
            this.menuGrid.RowHeadersWidth = 62;
            this.menuGrid.RowTemplate.Height = 30;
            this.menuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGrid.Size = new System.Drawing.Size(1415, 794);
            this.menuGrid.TabIndex = 0;
            this.menuGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGrid_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtBoxPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCat2);
            this.groupBox1.Controls.Add(this.comboBoxIngredientOrigin);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtBoxID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1400, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴 검색";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "원산지";
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Location = new System.Drawing.Point(715, 37);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(132, 28);
            this.lblCat2.TabIndex = 9;
            this.lblCat2.Text = "세부카테고리";
            // 
            // comboBoxIngredientOrigin
            // 
            this.comboBoxIngredientOrigin.FormattingEnabled = true;
            this.comboBoxIngredientOrigin.Location = new System.Drawing.Point(943, 68);
            this.comboBoxIngredientOrigin.Name = "comboBoxIngredientOrigin";
            this.comboBoxIngredientOrigin.Size = new System.Drawing.Size(191, 36);
            this.comboBoxIngredientOrigin.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(261, 37);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 28);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "가격";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(40, 68);
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(191, 36);
            this.txtBoxID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "카테고리";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(497, 68);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(191, 36);
            this.categoryComboBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1189, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 110);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 36);
            // 
            // 메뉴삭제ToolStripMenuItem
            // 
            this.메뉴삭제ToolStripMenuItem.Name = "메뉴삭제ToolStripMenuItem";
            this.메뉴삭제ToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.메뉴삭제ToolStripMenuItem.Text = "메뉴 삭제";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(266, 68);
            this.txtBoxPrice.Multiline = true;
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(191, 36);
            this.txtBoxPrice.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(720, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 36);
            this.comboBox1.TabIndex = 18;
            // 
            // OrderAndPayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderAndPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "아웃백스테이크하우스 - 주문/결제";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.orderpayLayout.ResumeLayout(false);
            this.orderPaySystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addMenuGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowMenuGridView)).EndInit();
            this.menuSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel orderpayLayout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴삭제ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TableLayoutPanel orderPaySystem;
        private System.Windows.Forms.DataGridView addMenuGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltableName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTablePay;
        private System.Windows.Forms.Button btnTableOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSum;
        private System.Windows.Forms.TableLayoutPanel menuSearch;
        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCat2;
        private System.Windows.Forms.ComboBox comboBoxIngredientOrigin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView nowMenuGridView;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}