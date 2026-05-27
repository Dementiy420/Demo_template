namespace Demo_template.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            SaveData = new Button();
            button3 = new Button();
            tabPage5 = new TabPage();
            customersGridView = new DataGridView();
            customerBindingSource = new BindingSource(components);
            tabPage4 = new TabPage();
            OpenOrderTable = new Button();
            OrdersGridView = new DataGridView();
            orderBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            SpecificationGridView = new DataGridView();
            specificationBindingSource = new BindingSource(components);
            tabPage6 = new TabPage();
            MaterialsGridView = new DataGridView();
            materialBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            ProductGridView = new DataGridView();
            productBindingSource = new BindingSource(components);
            tabPage1 = new TabPage();
            UsersGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            captchaAttemptsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            menuStrip1 = new MenuStrip();
            тестированиеAPIToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            customersIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            salesmanIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueproductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            innDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesmanDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            buyerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpecificationGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)specificationBindingSource).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaterialsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveData
            // 
            SaveData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveData.Location = new Point(8, 448);
            SaveData.Margin = new Padding(4, 3, 4, 3);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(147, 43);
            SaveData.TabIndex = 1;
            SaveData.Text = "Сохранить данные";
            SaveData.UseVisualStyleBackColor = true;
            SaveData.Click += SaveData_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(162, 448);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(147, 43);
            button3.TabIndex = 2;
            button3.Text = "Удалить строку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteRow_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(customersGridView);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(4, 3, 4, 3);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(786, 370);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Поставщики";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // customersGridView
            // 
            customersGridView.AutoGenerateColumns = false;
            customersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, nameDataGridViewTextBoxColumn2, innDataGridViewTextBoxColumn, addresDataGridViewTextBoxColumn, salesmanDataGridViewTextBoxColumn1, buyerDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            customersGridView.DataSource = customerBindingSource;
            customersGridView.Dock = DockStyle.Fill;
            customersGridView.Location = new Point(0, 0);
            customersGridView.Margin = new Padding(4, 3, 4, 3);
            customersGridView.Name = "customersGridView";
            customersGridView.Size = new Size(786, 370);
            customersGridView.TabIndex = 3;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Demo_entity.Models.Customer);
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(OpenOrderTable);
            tabPage4.Controls.Add(OrdersGridView);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(786, 370);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Заказы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // OpenOrderTable
            // 
            OpenOrderTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenOrderTable.Location = new Point(637, 337);
            OpenOrderTable.Margin = new Padding(4, 3, 4, 3);
            OpenOrderTable.Name = "OpenOrderTable";
            OpenOrderTable.Size = new Size(142, 27);
            OpenOrderTable.TabIndex = 3;
            OpenOrderTable.Text = "Рассчитать заказы";
            OpenOrderTable.UseVisualStyleBackColor = true;
            OpenOrderTable.Click += OpenOrderTable_Click;
            // 
            // OrdersGridView
            // 
            OrdersGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersGridView.AutoGenerateColumns = false;
            OrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, salesmanIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn1, dateDataGridViewTextBoxColumn, valueproductDataGridViewTextBoxColumn });
            OrdersGridView.DataSource = orderBindingSource;
            OrdersGridView.Location = new Point(0, 0);
            OrdersGridView.Margin = new Padding(4, 3, 4, 3);
            OrdersGridView.Name = "OrdersGridView";
            OrdersGridView.Size = new Size(785, 330);
            OrdersGridView.TabIndex = 2;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Demo_entity.Models.Order);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(SpecificationGridView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(786, 370);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Спецификации";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // SpecificationGridView
            // 
            SpecificationGridView.AutoGenerateColumns = false;
            SpecificationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SpecificationGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpecificationGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, customersIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, materialIdDataGridViewTextBoxColumn });
            SpecificationGridView.DataSource = specificationBindingSource;
            SpecificationGridView.Dock = DockStyle.Fill;
            SpecificationGridView.Location = new Point(0, 0);
            SpecificationGridView.Margin = new Padding(4, 3, 4, 3);
            SpecificationGridView.Name = "SpecificationGridView";
            SpecificationGridView.Size = new Size(786, 370);
            SpecificationGridView.TabIndex = 1;
            // 
            // specificationBindingSource
            // 
            specificationBindingSource.DataSource = typeof(Demo_entity.Models.Specification);
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(MaterialsGridView);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(4, 3, 4, 3);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(786, 370);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Материалы";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // MaterialsGridView
            // 
            MaterialsGridView.AutoGenerateColumns = false;
            MaterialsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MaterialsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaterialsGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, weightDataGridViewTextBoxColumn });
            MaterialsGridView.DataSource = materialBindingSource;
            MaterialsGridView.Dock = DockStyle.Fill;
            MaterialsGridView.Location = new Point(0, 0);
            MaterialsGridView.Margin = new Padding(4, 3, 4, 3);
            MaterialsGridView.Name = "MaterialsGridView";
            MaterialsGridView.Size = new Size(786, 370);
            MaterialsGridView.TabIndex = 1;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Demo_entity.Models.Material);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ProductGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(786, 370);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Продукты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            ProductGridView.AutoGenerateColumns = false;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            ProductGridView.DataSource = productBindingSource;
            ProductGridView.Dock = DockStyle.Fill;
            ProductGridView.Location = new Point(4, 3);
            ProductGridView.Margin = new Padding(4, 3, 4, 3);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.Size = new Size(778, 364);
            ProductGridView.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Demo_entity.Models.Product);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(UsersGridView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(786, 370);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Управление пользователями";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // UsersGridView
            // 
            UsersGridView.AutoGenerateColumns = false;
            UsersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGridView.Columns.AddRange(new DataGridViewColumn[] { Id, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, captchaAttemptsDataGridViewTextBoxColumn });
            UsersGridView.DataSource = userBindingSource;
            UsersGridView.Dock = DockStyle.Fill;
            UsersGridView.Location = new Point(4, 3);
            UsersGridView.Margin = new Padding(4, 3, 4, 3);
            UsersGridView.MultiSelect = false;
            UsersGridView.Name = "UsersGridView";
            UsersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGridView.Size = new Size(778, 364);
            UsersGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // captchaAttemptsDataGridViewTextBoxColumn
            // 
            captchaAttemptsDataGridViewTextBoxColumn.DataPropertyName = "CaptchaAttempts";
            captchaAttemptsDataGridViewTextBoxColumn.HeaderText = "CaptchaAttempts";
            captchaAttemptsDataGridViewTextBoxColumn.Name = "captchaAttemptsDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Demo_entity.Models.User);
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 46);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 398);
            tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.GripMargin = new Padding(0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { тестированиеAPIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // тестированиеAPIToolStripMenuItem
            // 
            тестированиеAPIToolStripMenuItem.Name = "тестированиеAPIToolStripMenuItem";
            тестированиеAPIToolStripMenuItem.Size = new Size(116, 24);
            тестированиеAPIToolStripMenuItem.Text = "Тестирование API";
            тестированиеAPIToolStripMenuItem.Click += тестированиеAPIToolStripMenuItem_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            dataGridViewTextBoxColumn3.HeaderText = "Id";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // customersIdDataGridViewTextBoxColumn
            // 
            customersIdDataGridViewTextBoxColumn.DataPropertyName = "CustomersId";
            customersIdDataGridViewTextBoxColumn.HeaderText = "CustomersId";
            customersIdDataGridViewTextBoxColumn.Name = "customersIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            materialIdDataGridViewTextBoxColumn.HeaderText = "MaterialId";
            materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            dataGridViewTextBoxColumn4.HeaderText = "Id";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // salesmanIdDataGridViewTextBoxColumn
            // 
            salesmanIdDataGridViewTextBoxColumn.DataPropertyName = "SalesmanId";
            salesmanIdDataGridViewTextBoxColumn.HeaderText = "SalesmanId";
            salesmanIdDataGridViewTextBoxColumn.Name = "salesmanIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            productIdDataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn1.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // valueproductDataGridViewTextBoxColumn
            // 
            valueproductDataGridViewTextBoxColumn.DataPropertyName = "Valueproduct";
            valueproductDataGridViewTextBoxColumn.HeaderText = "Valueproduct";
            valueproductDataGridViewTextBoxColumn.Name = "valueproductDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // innDataGridViewTextBoxColumn
            // 
            innDataGridViewTextBoxColumn.DataPropertyName = "Inn";
            innDataGridViewTextBoxColumn.HeaderText = "Inn";
            innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // salesmanDataGridViewTextBoxColumn1
            // 
            salesmanDataGridViewTextBoxColumn1.DataPropertyName = "Salesman";
            salesmanDataGridViewTextBoxColumn1.HeaderText = "Salesman";
            salesmanDataGridViewTextBoxColumn1.Name = "salesmanDataGridViewTextBoxColumn1";
            // 
            // buyerDataGridViewTextBoxColumn
            // 
            buyerDataGridViewTextBoxColumn.DataPropertyName = "Buyer";
            buyerDataGridViewTextBoxColumn.HeaderText = "Buyer";
            buyerDataGridViewTextBoxColumn.Name = "buyerDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 532);
            Controls.Add(button3);
            Controls.Add(SaveData);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(814, 571);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpecificationGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)specificationBindingSource).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MaterialsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView SpecificationGridView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView MaterialsGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестированиеAPIToolStripMenuItem;
        private System.Windows.Forms.Button OpenOrderTable;
        private BindingSource productBindingSource;
        private BindingSource userBindingSource;
        private BindingSource customerBindingSource;
        private BindingSource orderBindingSource;
        private BindingSource specificationBindingSource;
        private BindingSource materialBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn captchaAttemptsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesmanDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn buyerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn salesmanIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueproductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn customersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
    }
}