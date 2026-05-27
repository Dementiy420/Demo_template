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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picture_2 = new System.Windows.Forms.PictureBox();
            this.picture_3 = new System.Windows.Forms.PictureBox();
            this.picture_4 = new System.Windows.Forms.PictureBox();
            this.picture_1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendCaptcha = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picture_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picture_3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picture_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picture_1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picture_2
            // 
            this.picture_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_2.Location = new System.Drawing.Point(125, 0);
            this.picture_2.Margin = new System.Windows.Forms.Padding(0);
            this.picture_2.Name = "picture_2";
            this.picture_2.Size = new System.Drawing.Size(125, 125);
            this.picture_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_2.TabIndex = 10;
            this.picture_2.TabStop = false;
            this.picture_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.image_DragDrop);
            this.picture_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.image_DragEnter);
            // 
            // picture_3
            // 
            this.picture_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_3.Location = new System.Drawing.Point(0, 125);
            this.picture_3.Margin = new System.Windows.Forms.Padding(0);
            this.picture_3.Name = "picture_3";
            this.picture_3.Size = new System.Drawing.Size(125, 125);
            this.picture_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_3.TabIndex = 9;
            this.picture_3.TabStop = false;
            this.picture_3.DragDrop += new System.Windows.Forms.DragEventHandler(this.image_DragDrop);
            this.picture_3.DragEnter += new System.Windows.Forms.DragEventHandler(this.image_DragEnter);
            // 
            // picture_4
            // 
            this.picture_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_4.Location = new System.Drawing.Point(125, 125);
            this.picture_4.Margin = new System.Windows.Forms.Padding(0);
            this.picture_4.Name = "picture_4";
            this.picture_4.Size = new System.Drawing.Size(125, 125);
            this.picture_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_4.TabIndex = 8;
            this.picture_4.TabStop = false;
            this.picture_4.DragDrop += new System.Windows.Forms.DragEventHandler(this.image_DragDrop);
            this.picture_4.DragEnter += new System.Windows.Forms.DragEventHandler(this.image_DragEnter);
            // 
            // picture_1
            // 
            this.picture_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_1.Location = new System.Drawing.Point(0, 0);
            this.picture_1.Margin = new System.Windows.Forms.Padding(0);
            this.picture_1.Name = "picture_1";
            this.picture_1.Size = new System.Drawing.Size(125, 125);
            this.picture_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_1.TabIndex = 7;
            this.picture_1.TabStop = false;
            this.picture_1.DragDrop += new System.Windows.Forms.DragEventHandler(this.image_DragDrop);
            this.picture_1.DragEnter += new System.Windows.Forms.DragEventHandler(this.image_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(538, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 250);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(125, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 127);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "picture_1";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 127);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "picture_2";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "picture_3";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "picture_4";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Верификация CAPTCHA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendCaptcha
            // 
            this.SendCaptcha.Location = new System.Drawing.Point(326, 400);
            this.SendCaptcha.Name = "SendCaptcha";
            this.SendCaptcha.Size = new System.Drawing.Size(137, 38);
            this.SendCaptcha.TabIndex = 3;
            this.SendCaptcha.Text = "Пройти проверку";
            this.SendCaptcha.UseVisualStyleBackColor = true;
            this.SendCaptcha.Click += new System.EventHandler(this.SendCaptcha_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendCaptcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Captcha";
            this.Text = "Captcha";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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