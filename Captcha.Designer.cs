namespace Demo_template.Forms
{
    partial class Captcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captcha));
            tableLayoutPanel1 = new TableLayoutPanel();
            picture_2 = new PictureBox();
            picture_3 = new PictureBox();
            picture_4 = new PictureBox();
            picture_1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SendCaptcha = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(picture_2, 1, 0);
            tableLayoutPanel1.Controls.Add(picture_3, 0, 1);
            tableLayoutPanel1.Controls.Add(picture_4, 0, 1);
            tableLayoutPanel1.Controls.Add(picture_1, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 92);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(292, 288);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picture_2
            // 
            picture_2.BackgroundImageLayout = ImageLayout.Stretch;
            picture_2.BorderStyle = BorderStyle.FixedSingle;
            picture_2.Dock = DockStyle.Fill;
            picture_2.Location = new Point(146, 0);
            picture_2.Margin = new Padding(0);
            picture_2.Name = "picture_2";
            picture_2.Size = new Size(146, 144);
            picture_2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_2.TabIndex = 10;
            picture_2.TabStop = false;
            picture_2.DragDrop += image_DragDrop;
            picture_2.DragEnter += image_DragEnter;
            // 
            // picture_3
            // 
            picture_3.BackgroundImageLayout = ImageLayout.Stretch;
            picture_3.BorderStyle = BorderStyle.FixedSingle;
            picture_3.Dock = DockStyle.Fill;
            picture_3.Location = new Point(0, 144);
            picture_3.Margin = new Padding(0);
            picture_3.Name = "picture_3";
            picture_3.Size = new Size(146, 144);
            picture_3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_3.TabIndex = 9;
            picture_3.TabStop = false;
            picture_3.DragDrop += image_DragDrop;
            picture_3.DragEnter += image_DragEnter;
            // 
            // picture_4
            // 
            picture_4.BackgroundImageLayout = ImageLayout.Stretch;
            picture_4.BorderStyle = BorderStyle.FixedSingle;
            picture_4.Dock = DockStyle.Fill;
            picture_4.Location = new Point(146, 144);
            picture_4.Margin = new Padding(0);
            picture_4.Name = "picture_4";
            picture_4.Size = new Size(146, 144);
            picture_4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_4.TabIndex = 8;
            picture_4.TabStop = false;
            picture_4.DragDrop += image_DragDrop;
            picture_4.DragEnter += image_DragEnter;
            // 
            // picture_1
            // 
            picture_1.BackgroundImageLayout = ImageLayout.Stretch;
            picture_1.BorderStyle = BorderStyle.FixedSingle;
            picture_1.Dock = DockStyle.Fill;
            picture_1.Location = new Point(0, 0);
            picture_1.Margin = new Padding(0);
            picture_1.Name = "picture_1";
            picture_1.Size = new Size(146, 144);
            picture_1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_1.TabIndex = 7;
            picture_1.TabStop = false;
            picture_1.DragDrop += image_DragDrop;
            picture_1.DragEnter += image_DragEnter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel2.Location = new Point(628, 92);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new Size(292, 288);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(146, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(146, 146);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "picture_1";
            pictureBox4.MouseDown += image_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 146);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "picture_2";
            pictureBox2.MouseDown += image_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 146);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "picture_3";
            pictureBox3.MouseDown += image_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(146, 146);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "picture_4";
            pictureBox1.MouseDown += image_MouseDown;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(933, 52);
            label1.TabIndex = 2;
            label1.Text = "Верификация CAPTCHA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SendCaptcha
            // 
            SendCaptcha.Location = new Point(380, 462);
            SendCaptcha.Margin = new Padding(4, 3, 4, 3);
            SendCaptcha.Name = "SendCaptcha";
            SendCaptcha.Size = new Size(160, 44);
            SendCaptcha.TabIndex = 3;
            SendCaptcha.Text = "Пройти проверку";
            SendCaptcha.UseVisualStyleBackColor = true;
            SendCaptcha.Click += SendCaptcha_Click;
            // 
            // Captcha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(SendCaptcha);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Captcha";
            Text = "Captcha";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picture_2;
        private System.Windows.Forms.PictureBox picture_3;
        private System.Windows.Forms.PictureBox picture_4;
        private System.Windows.Forms.PictureBox picture_1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button SendCaptcha;
    }
}