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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.usersSave = new System.Windows.Forms.Button();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProductsSave = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SpecificationSave = new System.Windows.Forms.Button();
            this.SpecificationGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.OrderSave = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CustomerSave = new System.Windows.Forms.Button();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.MaterialsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificationGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.usersSave);
            this.tabPage1.Controls.Add(this.UsersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Управление пользователями";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // usersSave
            // 
            this.usersSave.Location = new System.Drawing.Point(6, 356);
            this.usersSave.Name = "usersSave";
            this.usersSave.Size = new System.Drawing.Size(132, 37);
            this.usersSave.TabIndex = 1;
            this.usersSave.Text = "Сохранить данные";
            this.usersSave.UseVisualStyleBackColor = true;
            this.usersSave.Click += new System.EventHandler(this.UsersSave_Click);
            // 
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(792, 350);
            this.UsersGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProductsSave);
            this.tabPage2.Controls.Add(this.ProductGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProductsSave
            // 
            this.ProductsSave.Location = new System.Drawing.Point(6, 356);
            this.ProductsSave.Name = "ProductsSave";
            this.ProductsSave.Size = new System.Drawing.Size(132, 37);
            this.ProductsSave.TabIndex = 2;
            this.ProductsSave.Text = "Сохранить данные";
            this.ProductsSave.UseVisualStyleBackColor = true;
            this.ProductsSave.Click += new System.EventHandler(this.ProductSave_Click);
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(0, 0);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(792, 350);
            this.ProductGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SpecificationSave);
            this.tabPage3.Controls.Add(this.SpecificationGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Спецификации";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SpecificationSave
            // 
            this.SpecificationSave.Location = new System.Drawing.Point(3, 356);
            this.SpecificationSave.Name = "SpecificationSave";
            this.SpecificationSave.Size = new System.Drawing.Size(132, 37);
            this.SpecificationSave.TabIndex = 2;
            this.SpecificationSave.Text = "Сохранить данные";
            this.SpecificationSave.UseVisualStyleBackColor = true;
            this.SpecificationSave.Click += new System.EventHandler(this.SpecificationSave_Click);
            // 
            // SpecificationGridView
            // 
            this.SpecificationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecificationGridView.Location = new System.Drawing.Point(0, 0);
            this.SpecificationGridView.Name = "SpecificationGridView";
            this.SpecificationGridView.Size = new System.Drawing.Size(792, 350);
            this.SpecificationGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.OrderSave);
            this.tabPage4.Controls.Add(this.OrdersGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Заказы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // OrderSave
            // 
            this.OrderSave.Location = new System.Drawing.Point(8, 356);
            this.OrderSave.Name = "OrderSave";
            this.OrderSave.Size = new System.Drawing.Size(132, 37);
            this.OrderSave.TabIndex = 3;
            this.OrderSave.Text = "Сохранить данные";
            this.OrderSave.UseVisualStyleBackColor = true;
            this.OrderSave.Click += new System.EventHandler(this.OrderSave_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(792, 350);
            this.OrdersGridView.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CustomerSave);
            this.tabPage5.Controls.Add(this.customersGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Поставщики";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CustomerSave
            // 
            this.CustomerSave.Location = new System.Drawing.Point(8, 356);
            this.CustomerSave.Name = "CustomerSave";
            this.CustomerSave.Size = new System.Drawing.Size(132, 37);
            this.CustomerSave.TabIndex = 4;
            this.CustomerSave.Text = "Сохранить данные";
            this.CustomerSave.UseVisualStyleBackColor = true;
            this.CustomerSave.Click += new System.EventHandler(this.CustomersSave_Click);
            // 
            // customersGridView
            // 
            this.customersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Location = new System.Drawing.Point(0, 0);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.Size = new System.Drawing.Size(792, 350);
            this.customersGridView.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.MaterialsGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(792, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Материалы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // MaterialsGridView
            // 
            this.MaterialsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialsGridView.Location = new System.Drawing.Point(0, 0);
            this.MaterialsGridView.Name = "MaterialsGridView";
            this.MaterialsGridView.Size = new System.Drawing.Size(792, 350);
            this.MaterialsGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить данные";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Высчитать общие суммы заказов";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpecificationGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridView SpecificationGridView;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.Button usersSave;
        private System.Windows.Forms.Button ProductsSave;
        private System.Windows.Forms.Button SpecificationSave;
        private System.Windows.Forms.Button OrderSave;
        private System.Windows.Forms.Button CustomerSave;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MaterialsGridView;
        private System.Windows.Forms.Button button2;
    }
}