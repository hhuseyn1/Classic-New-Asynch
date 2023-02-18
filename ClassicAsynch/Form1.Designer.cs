namespace ClassicAsynch_NewAsynch
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBox_Authors = new System.Windows.Forms.ComboBox();
            this.cmbBox_Categories = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 106);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.Height = 25;
            this.gridView.Size = new System.Drawing.Size(776, 322);
            this.gridView.TabIndex = 8;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(103, 55);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 36);
            this.Btn_Update.TabIndex = 7;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Fill.Location = new System.Drawing.Point(12, 55);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(85, 36);
            this.Btn_Fill.TabIndex = 6;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 27);
            this.textBox1.TabIndex = 5;
            // 
            // cmbBox_Authors
            // 
            this.cmbBox_Authors.FormattingEnabled = true;
            this.cmbBox_Authors.Location = new System.Drawing.Point(12, 22);
            this.cmbBox_Authors.Name = "cmbBox_Authors";
            this.cmbBox_Authors.Size = new System.Drawing.Size(159, 23);
            this.cmbBox_Authors.TabIndex = 9;
            this.cmbBox_Authors.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Authors_SelectedIndexChanged);
            // 
            // cmbBox_Categories
            // 
            this.cmbBox_Categories.FormattingEnabled = true;
            this.cmbBox_Categories.Location = new System.Drawing.Point(196, 22);
            this.cmbBox_Categories.Name = "cmbBox_Categories";
            this.cmbBox_Categories.Size = new System.Drawing.Size(159, 23);
            this.cmbBox_Categories.TabIndex = 10;
            this.cmbBox_Categories.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Categories_SelectedIndexChanged);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Search.Location = new System.Drawing.Point(461, 64);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(85, 27);
            this.Btn_Search.TabIndex = 11;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.cmbBox_Categories);
            this.Controls.Add(this.cmbBox_Authors);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Fill);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridView;
        private Button Btn_Update;
        private Button Btn_Fill;
        private TextBox textBox1;
        private ComboBox cmbBox_Authors;
        private ComboBox cmbBox_Categories;
        private Button Btn_Search;
        private Label label1;
        private Label label2;
    }
}