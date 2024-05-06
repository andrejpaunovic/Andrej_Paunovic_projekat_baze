namespace Andrej_Paunovic_projekat_baze
{
    partial class Aplikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplikacija));
            this.cmb_Studio = new System.Windows.Forms.ComboBox();
            this.cmb_Date = new System.Windows.Forms.ComboBox();
            this.grid_termini = new System.Windows.Forms.DataGridView();
            this.cmb_od = new System.Windows.Forms.ComboBox();
            this.cmb_do = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_proveri = new System.Windows.Forms.Button();
            this.btn_zakazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Studio
            // 
            this.cmb_Studio.FormattingEnabled = true;
            this.cmb_Studio.Location = new System.Drawing.Point(16, 104);
            this.cmb_Studio.Name = "cmb_Studio";
            this.cmb_Studio.Size = new System.Drawing.Size(121, 24);
            this.cmb_Studio.TabIndex = 0;
            // 
            // cmb_Date
            // 
            this.cmb_Date.FormattingEnabled = true;
            this.cmb_Date.Location = new System.Drawing.Point(16, 40);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(121, 24);
            this.cmb_Date.TabIndex = 1;
            // 
            // grid_termini
            // 
            this.grid_termini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_termini.Location = new System.Drawing.Point(32, 274);
            this.grid_termini.Name = "grid_termini";
            this.grid_termini.RowHeadersWidth = 51;
            this.grid_termini.RowTemplate.Height = 24;
            this.grid_termini.Size = new System.Drawing.Size(1115, 244);
            this.grid_termini.TabIndex = 2;
            // 
            // cmb_od
            // 
            this.cmb_od.FormattingEnabled = true;
            this.cmb_od.Location = new System.Drawing.Point(424, 80);
            this.cmb_od.Name = "cmb_od";
            this.cmb_od.Size = new System.Drawing.Size(121, 24);
            this.cmb_od.TabIndex = 3;
            this.cmb_od.SelectedIndexChanged += new System.EventHandler(this.cmb_od_SelectedIndexChanged);
            // 
            // cmb_do
            // 
            this.cmb_do.FormattingEnabled = true;
            this.cmb_do.Location = new System.Drawing.Point(632, 80);
            this.cmb_do.Name = "cmb_do";
            this.cmb_do.Size = new System.Drawing.Size(121, 24);
            this.cmb_do.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(912, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btn_proveri
            // 
            this.btn_proveri.Location = new System.Drawing.Point(16, 176);
            this.btn_proveri.Name = "btn_proveri";
            this.btn_proveri.Size = new System.Drawing.Size(132, 41);
            this.btn_proveri.TabIndex = 6;
            this.btn_proveri.Text = "Proveri";
            this.btn_proveri.UseVisualStyleBackColor = true;
            this.btn_proveri.Click += new System.EventHandler(this.btn_proveri_Click);
            // 
            // btn_zakazi
            // 
            this.btn_zakazi.Location = new System.Drawing.Point(416, 136);
            this.btn_zakazi.Name = "btn_zakazi";
            this.btn_zakazi.Size = new System.Drawing.Size(336, 111);
            this.btn_zakazi.TabIndex = 7;
            this.btn_zakazi.Text = "Zakazi";
            this.btn_zakazi.UseVisualStyleBackColor = true;
            // 
            // Aplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 540);
            this.Controls.Add(this.btn_zakazi);
            this.Controls.Add(this.btn_proveri);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_do);
            this.Controls.Add(this.cmb_od);
            this.Controls.Add(this.grid_termini);
            this.Controls.Add(this.cmb_Date);
            this.Controls.Add(this.cmb_Studio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aplikacija";
            this.Text = "Belgrade Studios";
            this.Load += new System.EventHandler(this.Aplikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Studio;
        private System.Windows.Forms.ComboBox cmb_Date;
        private System.Windows.Forms.DataGridView grid_termini;
        private System.Windows.Forms.ComboBox cmb_od;
        private System.Windows.Forms.ComboBox cmb_do;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_proveri;
        private System.Windows.Forms.Button btn_zakazi;
    }
}