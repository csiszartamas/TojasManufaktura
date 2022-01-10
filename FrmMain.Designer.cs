namespace TojasManufaktura
{
    partial class FrmMain
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
            this.tbTermeles = new System.Windows.Forms.Button();
            this.tbStatisztika = new System.Windows.Forms.Button();
            this.tbKimutatas = new System.Windows.Forms.Button();
            this.tbKilepes = new System.Windows.Forms.Button();
            this.pbNyuszi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNyuszi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTermeles
            // 
            this.tbTermeles.Location = new System.Drawing.Point(16, 93);
            this.tbTermeles.Name = "tbTermeles";
            this.tbTermeles.Size = new System.Drawing.Size(450, 69);
            this.tbTermeles.TabIndex = 0;
            this.tbTermeles.Text = "Termelés";
            this.tbTermeles.UseVisualStyleBackColor = true;
            this.tbTermeles.Click += new System.EventHandler(this.tbTermeles_Click);
            // 
            // tbStatisztika
            // 
            this.tbStatisztika.Location = new System.Drawing.Point(16, 182);
            this.tbStatisztika.Name = "tbStatisztika";
            this.tbStatisztika.Size = new System.Drawing.Size(450, 65);
            this.tbStatisztika.TabIndex = 1;
            this.tbStatisztika.Text = "Statisztika";
            this.tbStatisztika.UseVisualStyleBackColor = true;
            this.tbStatisztika.Click += new System.EventHandler(this.tbStatisztika_Click);
            // 
            // tbKimutatas
            // 
            this.tbKimutatas.Location = new System.Drawing.Point(16, 268);
            this.tbKimutatas.Name = "tbKimutatas";
            this.tbKimutatas.Size = new System.Drawing.Size(450, 58);
            this.tbKimutatas.TabIndex = 2;
            this.tbKimutatas.Text = "Kimutatás";
            this.tbKimutatas.UseVisualStyleBackColor = true;
            // 
            // tbKilepes
            // 
            this.tbKilepes.Location = new System.Drawing.Point(16, 355);
            this.tbKilepes.Name = "tbKilepes";
            this.tbKilepes.Size = new System.Drawing.Size(450, 59);
            this.tbKilepes.TabIndex = 3;
            this.tbKilepes.Text = "Kilépés";
            this.tbKilepes.UseVisualStyleBackColor = true;
            this.tbKilepes.Click += new System.EventHandler(this.tbKilepes_Click);
            // 
            // pbNyuszi
            // 
            this.pbNyuszi.Location = new System.Drawing.Point(481, 93);
            this.pbNyuszi.Name = "pbNyuszi";
            this.pbNyuszi.Size = new System.Drawing.Size(307, 321);
            this.pbNyuszi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNyuszi.TabIndex = 4;
            this.pbNyuszi.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbNyuszi);
            this.Controls.Add(this.tbKilepes);
            this.Controls.Add(this.tbKimutatas);
            this.Controls.Add(this.tbStatisztika);
            this.Controls.Add(this.tbTermeles);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNyuszi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbTermeles;
        private System.Windows.Forms.Button tbStatisztika;
        private System.Windows.Forms.Button tbKimutatas;
        private System.Windows.Forms.Button tbKilepes;
        private System.Windows.Forms.PictureBox pbNyuszi;
    }
}

