namespace Andrej_Paunovic_projekat_baze
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.btn_Napravi = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grid_zakazivanje = new System.Windows.Forms.DataGridView();
            this.cmb_Date = new System.Windows.Forms.ComboBox();
            this.grid_termini = new System.Windows.Forms.DataGridView();
            this.btn_proveri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_zakazivanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Datum
            // 
            this.txt_Datum.Location = new System.Drawing.Point(48, 80);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.ReadOnly = true;
            this.txt_Datum.Size = new System.Drawing.Size(152, 22);
            this.txt_Datum.TabIndex = 0;
            // 
            // btn_Napravi
            // 
            this.btn_Napravi.Location = new System.Drawing.Point(72, 128);
            this.btn_Napravi.Name = "btn_Napravi";
            this.btn_Napravi.Size = new System.Drawing.Size(96, 40);
            this.btn_Napravi.TabIndex = 1;
            this.btn_Napravi.Text = "Napravi";
            this.btn_Napravi.UseVisualStyleBackColor = true;
            this.btn_Napravi.Click += new System.EventHandler(this.btn_Napravi_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "RADNI DAN";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grid_zakazivanje
            // 
            this.grid_zakazivanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_zakazivanje.Location = new System.Drawing.Point(728, 96);
            this.grid_zakazivanje.Name = "grid_zakazivanje";
            this.grid_zakazivanje.RowHeadersWidth = 51;
            this.grid_zakazivanje.RowTemplate.Height = 24;
            this.grid_zakazivanje.Size = new System.Drawing.Size(568, 150);
            this.grid_zakazivanje.TabIndex = 3;
            this.grid_zakazivanje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmb_Date
            // 
            this.cmb_Date.FormattingEnabled = true;
            this.cmb_Date.Location = new System.Drawing.Point(480, 80);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(121, 24);
            this.cmb_Date.TabIndex = 4;
            this.cmb_Date.SelectedIndexChanged += new System.EventHandler(this.cmb_Date_SelectedIndexChanged);
            // 
            // grid_termini
            // 
            this.grid_termini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_termini.Location = new System.Drawing.Point(16, 280);
            this.grid_termini.Name = "grid_termini";
            this.grid_termini.RowHeadersWidth = 51;
            this.grid_termini.RowTemplate.Height = 24;
            this.grid_termini.Size = new System.Drawing.Size(1280, 232);
            this.grid_termini.TabIndex = 5;
            // 
            // btn_proveri
            // 
            this.btn_proveri.Location = new System.Drawing.Point(488, 128);
            this.btn_proveri.Name = "btn_proveri";
            this.btn_proveri.Size = new System.Drawing.Size(107, 39);
            this.btn_proveri.TabIndex = 6;
            this.btn_proveri.Text = "Proveri";
            this.btn_proveri.UseVisualStyleBackColor = true;
            this.btn_proveri.Click += new System.EventHandler(this.btn_proveri_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 594);
            this.Controls.Add(this.btn_proveri);
            this.Controls.Add(this.grid_termini);
            this.Controls.Add(this.cmb_Date);
            this.Controls.Add(this.grid_zakazivanje);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Napravi);
            this.Controls.Add(this.txt_Datum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_zakazivanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.Button btn_Napravi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView grid_zakazivanje;
        private System.Windows.Forms.ComboBox cmb_Date;
        private System.Windows.Forms.DataGridView grid_termini;
        private System.Windows.Forms.Button btn_proveri;
    }
}