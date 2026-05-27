namespace Demo_template
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            Password_Entry = new TextBox();
            Login_Entry = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkCyan;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.427083F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.84375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.729167F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.386809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.15686F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.634581F));
            tableLayoutPanel1.Size = new Size(448, 647);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Password_Entry);
            panel1.Controls.Add(Login_Entry);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 21);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 595);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(4, 306);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(76, 24);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(4, 173);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 4;
            label2.Text = "Логин";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(7, 532);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(392, 46);
            button1.TabIndex = 3;
            button1.Text = "Войти в систему";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password_Entry
            // 
            Password_Entry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Password_Entry.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_Entry.Location = new Point(7, 333);
            Password_Entry.Margin = new Padding(0);
            Password_Entry.Name = "Password_Entry";
            Password_Entry.Size = new Size(391, 29);
            Password_Entry.TabIndex = 2;
            Password_Entry.UseSystemPasswordChar = true;
            // 
            // Login_Entry
            // 
            Login_Entry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Login_Entry.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Login_Entry.Location = new Point(7, 201);
            Login_Entry.Margin = new Padding(0);
            Login_Entry.Name = "Login_Entry";
            Login_Entry.Size = new Size(391, 29);
            Login_Entry.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.PaleTurquoise;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(402, 50);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(448, 647);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(464, 686);
            Name = "Login";
            Text = "Form1";
            FormClosed += Login_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password_Entry;
        private System.Windows.Forms.TextBox Login_Entry;
        private System.Windows.Forms.Label label1;
    }
}

