namespace Country_Information
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbContinenti = new System.Windows.Forms.ListBox();
            this.lbCapitale = new System.Windows.Forms.Label();
            this.lbPaesi = new System.Windows.Forms.ListBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLingua = new System.Windows.Forms.Label();
            this.lbPrefisso = new System.Windows.Forms.Label();
            this.lbMoneta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContinenti
            // 
            this.lbContinenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinenti.FormattingEnabled = true;
            this.lbContinenti.ItemHeight = 48;
            this.lbContinenti.Location = new System.Drawing.Point(354, 237);
            this.lbContinenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbContinenti.Name = "lbContinenti";
            this.lbContinenti.Size = new System.Drawing.Size(452, 1396);
            this.lbContinenti.TabIndex = 0;
            this.lbContinenti.Click += new System.EventHandler(this.lbContinenti_Click);
            this.lbContinenti.SelectedIndexChanged += new System.EventHandler(this.lbContinenti_SelectedIndexChanged);
            // 
            // lbCapitale
            // 
            this.lbCapitale.AutoSize = true;
            this.lbCapitale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapitale.Location = new System.Drawing.Point(2587, 1325);
            this.lbCapitale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCapitale.Name = "lbCapitale";
            this.lbCapitale.Size = new System.Drawing.Size(207, 63);
            this.lbCapitale.TabIndex = 1;
            this.lbCapitale.Text = "............";
            // 
            // lbPaesi
            // 
            this.lbPaesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaesi.FormattingEnabled = true;
            this.lbPaesi.ItemHeight = 48;
            this.lbPaesi.Location = new System.Drawing.Point(844, 237);
            this.lbPaesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbPaesi.Name = "lbPaesi";
            this.lbPaesi.Size = new System.Drawing.Size(672, 1396);
            this.lbPaesi.TabIndex = 2;
            this.lbPaesi.Click += new System.EventHandler(this.lbPaesi_Click);
            this.lbPaesi.SelectedIndexChanged += new System.EventHandler(this.lbPaesi_SelectedIndexChanged);
            // 
            // pb1
            // 
            this.pb1.ImageLocation = "";
            this.pb1.Location = new System.Drawing.Point(1879, 362);
            this.pb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1222, 863);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.visualizzaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(3112, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2233, 1325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Capital:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2115, 1487);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 63);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone code:";
            // 
            // lbLingua
            // 
            this.lbLingua.AutoSize = true;
            this.lbLingua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLingua.Location = new System.Drawing.Point(2587, 1404);
            this.lbLingua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLingua.Name = "lbLingua";
            this.lbLingua.Size = new System.Drawing.Size(207, 63);
            this.lbLingua.TabIndex = 8;
            this.lbLingua.Text = "............";
            // 
            // lbPrefisso
            // 
            this.lbPrefisso.AutoSize = true;
            this.lbPrefisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrefisso.Location = new System.Drawing.Point(2587, 1487);
            this.lbPrefisso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrefisso.Name = "lbPrefisso";
            this.lbPrefisso.Size = new System.Drawing.Size(207, 63);
            this.lbPrefisso.TabIndex = 9;
            this.lbPrefisso.Text = "............";
            this.lbPrefisso.Click += new System.EventHandler(this.lbPrefisso_Click);
            // 
            // lbMoneta
            // 
            this.lbMoneta.AutoSize = true;
            this.lbMoneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneta.Location = new System.Drawing.Point(2587, 1562);
            this.lbMoneta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMoneta.Name = "lbMoneta";
            this.lbMoneta.Size = new System.Drawing.Size(207, 63);
            this.lbMoneta.TabIndex = 11;
            this.lbMoneta.Text = "............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2163, 1404);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "Language:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2181, 1562);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 63);
            this.label4.TabIndex = 10;
            this.label4.Text = "Currency:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(3112, 1658);
            this.Controls.Add(this.lbMoneta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPrefisso);
            this.Controls.Add(this.lbLingua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbPaesi);
            this.Controls.Add(this.lbCapitale);
            this.Controls.Add(this.lbContinenti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Country Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContinenti;
        private System.Windows.Forms.Label lbCapitale;
        private System.Windows.Forms.ListBox lbPaesi;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLingua;
        private System.Windows.Forms.Label lbPrefisso;
        private System.Windows.Forms.Label lbMoneta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

