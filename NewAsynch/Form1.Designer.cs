namespace NewAsynch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Fill.Location = new System.Drawing.Point(12, 65);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(85, 36);
            this.Btn_Fill.TabIndex = 1;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(103, 65);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 36);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 116);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(776, 322);
            this.gridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Fill);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button Btn_Fill;
        private Button Btn_Update;
        private DataGridView gridView;
    }
}