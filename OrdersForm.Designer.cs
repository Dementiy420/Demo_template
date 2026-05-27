namespace Demo_template.Forms
{
    partial class OrdersForm
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
            OdersGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OdersGridView).BeginInit();
            SuspendLayout();
            // 
            // OdersGridView
            // 
            OdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OdersGridView.Location = new Point(14, 14);
            OdersGridView.Margin = new Padding(4, 3, 4, 3);
            OdersGridView.Name = "OdersGridView";
            OdersGridView.Size = new Size(887, 504);
            OdersGridView.TabIndex = 0;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(OdersGridView);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 571);
            MinimumSize = new Size(931, 571);
            Name = "OrdersForm";
            Text = "OrdersForm";
            FormClosed += OrdersForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)OdersGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OdersGridView;
    }
}