namespace TojasManufaktura
{
    partial class FrmTermeles
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbTojas = new System.Windows.Forms.ComboBox();
            this.nudMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.cbMunkas = new System.Windows.Forms.ComboBox();
            this.btnUjbejegyzes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Szin,
            this.Mennyiseg,
            this.Munkas});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(524, 238);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tojás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Munkás:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(6, 94);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(126, 23);
            this.dtpDatum.TabIndex = 4;
            // 
            // cbTojas
            // 
            this.cbTojas.FormattingEnabled = true;
            this.cbTojas.Location = new System.Drawing.Point(138, 94);
            this.cbTojas.Name = "cbTojas";
            this.cbTojas.Size = new System.Drawing.Size(103, 24);
            this.cbTojas.TabIndex = 5;
            // 
            // nudMennyiseg
            // 
            this.nudMennyiseg.Location = new System.Drawing.Point(247, 94);
            this.nudMennyiseg.Name = "nudMennyiseg";
            this.nudMennyiseg.Size = new System.Drawing.Size(84, 23);
            this.nudMennyiseg.TabIndex = 6;
            // 
            // cbMunkas
            // 
            this.cbMunkas.FormattingEnabled = true;
            this.cbMunkas.Location = new System.Drawing.Point(337, 93);
            this.cbMunkas.Name = "cbMunkas";
            this.cbMunkas.Size = new System.Drawing.Size(187, 24);
            this.cbMunkas.TabIndex = 7;
            // 
            // btnUjbejegyzes
            // 
            this.btnUjbejegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjbejegyzes.Location = new System.Drawing.Point(6, 138);
            this.btnUjbejegyzes.Name = "btnUjbejegyzes";
            this.btnUjbejegyzes.Size = new System.Drawing.Size(518, 45);
            this.btnUjbejegyzes.TabIndex = 8;
            this.btnUjbejegyzes.Text = "Új bejegyzés felvétele!";
            this.btnUjbejegyzes.UseVisualStyleBackColor = true;
            this.btnUjbejegyzes.Click += new System.EventHandler(this.BtnUjbejegyzes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.btnUjbejegyzes);
            this.groupBox1.Controls.Add(this.cbMunkas);
            this.groupBox1.Controls.Add(this.nudMennyiseg);
            this.groupBox1.Controls.Add(this.cbTojas);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új bejegyzés";
            // 
            // Datum
            // 
            this.Datum.FillWeight = 81.21828F;
            this.Datum.HeaderText = "Dátum";
            this.Datum.Name = "Datum";
            // 
            // Szin
            // 
            this.Szin.FillWeight = 82.68068F;
            this.Szin.HeaderText = "Tojás színe";
            this.Szin.Name = "Szin";
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.FillWeight = 63.38349F;
            this.Mennyiseg.HeaderText = "Mennyiség";
            this.Mennyiseg.Name = "Mennyiseg";
            // 
            // Munkas
            // 
            this.Munkas.FillWeight = 172.7176F;
            this.Munkas.HeaderText = "Munkás";
            this.Munkas.Name = "Munkas";
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(551, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTermeles";
            this.Text = "FrmTermeles";
            this.Load += new System.EventHandler(this.FrmTermeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbTojas;
        private System.Windows.Forms.NumericUpDown nudMennyiseg;
        private System.Windows.Forms.ComboBox cbMunkas;
        private System.Windows.Forms.Button btnUjbejegyzes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}