namespace omdb_film_bottagisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.movieImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.NResult = new System.Windows.Forms.ComboBox();
            this.lbNResult = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Trama = new System.Windows.Forms.Label();
            this.Anno = new System.Windows.Forms.Label();
            this.DVD = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Stato = new System.Windows.Forms.Label();
            this.Regia = new System.Windows.Forms.Label();
            this.Durata = new System.Windows.Forms.Label();
            this.Produzione = new System.Windows.Forms.Label();
            this.lbTrama = new System.Windows.Forms.Label();
            this.lbDurata = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbDVD = new System.Windows.Forms.Label();
            this.lbAnno = new System.Windows.Forms.Label();
            this.lbStato = new System.Windows.Forms.Label();
            this.lbRegia = new System.Windows.Forms.Label();
            this.lbProduzione = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Titolo = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(42, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(674, 66);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::omdb_film_bottagisi.Properties.Resources.buttonSearch;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(770, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 81);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65535, 1710);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbDescription);
            this.panel2.Controls.Add(this.lvMovie);
            this.panel2.Location = new System.Drawing.Point(898, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65429, 1710);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(30, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 100);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31813, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(699, 58);
            this.label3.TabIndex = 3;
            this.label3.Text = "Luca Bottagisi | SimilNetflix | 5IC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31813, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(699, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Luca Bottagisi | SimilNetflix | 5IC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31813, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luca Bottagisi | SimilNetflix | 5IC";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(1717, 19);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(699, 58);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Luca Bottagisi | SimilNetflix | 5IC";
            // 
            // lvMovie
            // 
            this.lvMovie.AutoArrange = false;
            this.lvMovie.BackColor = System.Drawing.Color.Red;
            this.lvMovie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMovie.HideSelection = false;
            this.lvMovie.LargeImageList = this.movieImageList;
            this.lvMovie.Location = new System.Drawing.Point(1543, 246);
            this.lvMovie.MultiSelect = false;
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(1209, 1408);
            this.lvMovie.TabIndex = 7;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.View = System.Windows.Forms.View.Details;
            this.lvMovie.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMovie_ItemSelectionChanged);
            // 
            // movieImageList
            // 
            this.movieImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.movieImageList.ImageSize = new System.Drawing.Size(100, 100);
            this.movieImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Controls.Add(this.NResult);
            this.panel6.Controls.Add(this.lbNResult);
            this.panel6.Location = new System.Drawing.Point(1114, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(451, 100);
            this.panel6.TabIndex = 0;
            // 
            // NResult
            // 
            this.NResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NResult.DropDownWidth = 205;
            this.NResult.FormattingEnabled = true;
            this.NResult.ItemHeight = 25;
            this.NResult.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100"});
            this.NResult.Location = new System.Drawing.Point(306, 32);
            this.NResult.Name = "NResult";
            this.NResult.Size = new System.Drawing.Size(121, 33);
            this.NResult.TabIndex = 1;
            this.NResult.SelectedIndexChanged += new System.EventHandler(this.NResult_SelectedIndexChanged);
            // 
            // lbNResult
            // 
            this.lbNResult.AutoSize = true;
            this.lbNResult.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNResult.Location = new System.Drawing.Point(24, 20);
            this.lbNResult.Name = "lbNResult";
            this.lbNResult.Size = new System.Drawing.Size(209, 58);
            this.lbNResult.TabIndex = 0;
            this.lbNResult.Text = "N. Result";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 2119);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(2459, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = "Movies List";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3853, 108);
            this.panel4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(106, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 79);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.lbTrama);
            this.panel8.Controls.Add(this.lbDurata);
            this.panel8.Controls.Add(this.lbTipo);
            this.panel8.Controls.Add(this.lbDVD);
            this.panel8.Controls.Add(this.lbAnno);
            this.panel8.Controls.Add(this.lbStato);
            this.panel8.Controls.Add(this.lbRegia);
            this.panel8.Controls.Add(this.lbProduzione);
            this.panel8.Location = new System.Drawing.Point(120, 300);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2137, 1411);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox);
            this.panel9.Controls.Add(this.Trama);
            this.panel9.Controls.Add(this.Anno);
            this.panel9.Controls.Add(this.DVD);
            this.panel9.Controls.Add(this.Tipo);
            this.panel9.Controls.Add(this.Stato);
            this.panel9.Controls.Add(this.Regia);
            this.panel9.Controls.Add(this.Durata);
            this.panel9.Controls.Add(this.Produzione);
            this.panel9.Location = new System.Drawing.Point(547, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1587, 1350);
            this.panel9.TabIndex = 18;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(654, 64);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(910, 1033);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Trama
            // 
            this.Trama.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trama.Location = new System.Drawing.Point(27, 860);
            this.Trama.Name = "Trama";
            this.Trama.Size = new System.Drawing.Size(630, 460);
            this.Trama.TabIndex = 17;
            this.Trama.Text = "----------";
            // 
            // Anno
            // 
            this.Anno.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anno.Location = new System.Drawing.Point(27, 407);
            this.Anno.Name = "Anno";
            this.Anno.Size = new System.Drawing.Size(630, 115);
            this.Anno.TabIndex = 11;
            this.Anno.Text = "----------";
            // 
            // DVD
            // 
            this.DVD.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVD.Location = new System.Drawing.Point(27, 522);
            this.DVD.Name = "DVD";
            this.DVD.Size = new System.Drawing.Size(630, 98);
            this.DVD.TabIndex = 10;
            this.DVD.Text = "----------";
            // 
            // Tipo
            // 
            this.Tipo.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(27, 620);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(630, 126);
            this.Tipo.TabIndex = 16;
            this.Tipo.Text = "----------";
            // 
            // Stato
            // 
            this.Stato.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stato.Location = new System.Drawing.Point(27, 300);
            this.Stato.Name = "Stato";
            this.Stato.Size = new System.Drawing.Size(630, 107);
            this.Stato.TabIndex = 12;
            this.Stato.Text = "----------";
            // 
            // Regia
            // 
            this.Regia.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regia.Location = new System.Drawing.Point(27, 197);
            this.Regia.Name = "Regia";
            this.Regia.Size = new System.Drawing.Size(630, 103);
            this.Regia.TabIndex = 13;
            this.Regia.Text = "----------";
            // 
            // Durata
            // 
            this.Durata.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durata.Location = new System.Drawing.Point(27, 734);
            this.Durata.Name = "Durata";
            this.Durata.Size = new System.Drawing.Size(630, 102);
            this.Durata.TabIndex = 15;
            this.Durata.Text = "----------";
            // 
            // Produzione
            // 
            this.Produzione.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produzione.Location = new System.Drawing.Point(27, 103);
            this.Produzione.Name = "Produzione";
            this.Produzione.Size = new System.Drawing.Size(630, 101);
            this.Produzione.TabIndex = 14;
            this.Produzione.Text = "----------";
            // 
            // lbTrama
            // 
            this.lbTrama.AutoSize = true;
            this.lbTrama.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrama.Location = new System.Drawing.Point(61, 895);
            this.lbTrama.Name = "lbTrama";
            this.lbTrama.Size = new System.Drawing.Size(141, 50);
            this.lbTrama.TabIndex = 8;
            this.lbTrama.Text = "Trama:";
            // 
            // lbDurata
            // 
            this.lbDurata.AutoSize = true;
            this.lbDurata.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDurata.Location = new System.Drawing.Point(61, 764);
            this.lbDurata.Name = "lbDurata";
            this.lbDurata.Size = new System.Drawing.Size(149, 50);
            this.lbDurata.TabIndex = 7;
            this.lbDurata.Text = "Durata:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(55, 650);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(112, 50);
            this.lbTipo.TabIndex = 6;
            this.lbTipo.Text = "Tipo:";
            this.lbTipo.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbDVD
            // 
            this.lbDVD.AutoSize = true;
            this.lbDVD.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVD.Location = new System.Drawing.Point(55, 552);
            this.lbDVD.Name = "lbDVD";
            this.lbDVD.Size = new System.Drawing.Size(122, 50);
            this.lbDVD.TabIndex = 5;
            this.lbDVD.Text = "DVD:";
            // 
            // lbAnno
            // 
            this.lbAnno.AutoSize = true;
            this.lbAnno.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnno.Location = new System.Drawing.Point(55, 437);
            this.lbAnno.Name = "lbAnno";
            this.lbAnno.Size = new System.Drawing.Size(127, 50);
            this.lbAnno.TabIndex = 4;
            this.lbAnno.Text = "Anno:";
            // 
            // lbStato
            // 
            this.lbStato.AutoSize = true;
            this.lbStato.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStato.Location = new System.Drawing.Point(55, 330);
            this.lbStato.Name = "lbStato";
            this.lbStato.Size = new System.Drawing.Size(118, 50);
            this.lbStato.TabIndex = 3;
            this.lbStato.Text = "Stato:";
            // 
            // lbRegia
            // 
            this.lbRegia.AutoSize = true;
            this.lbRegia.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegia.Location = new System.Drawing.Point(61, 227);
            this.lbRegia.Name = "lbRegia";
            this.lbRegia.Size = new System.Drawing.Size(128, 50);
            this.lbRegia.TabIndex = 2;
            this.lbRegia.Text = "Regia:";
            // 
            // lbProduzione
            // 
            this.lbProduzione.AutoSize = true;
            this.lbProduzione.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduzione.Location = new System.Drawing.Point(61, 133);
            this.lbProduzione.Name = "lbProduzione";
            this.lbProduzione.Size = new System.Drawing.Size(229, 50);
            this.lbProduzione.TabIndex = 1;
            this.lbProduzione.Text = "Produzione:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.Titolo);
            this.panel7.Location = new System.Drawing.Point(120, 300);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2134, 135);
            this.panel7.TabIndex = 19;
            // 
            // Titolo
            // 
            this.Titolo.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(-8, 5);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(2128, 133);
            this.Titolo.TabIndex = 18;
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titolo.Click += new System.EventHandler(this.lbName_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(0, 1826);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(3853, 100);
            this.panel10.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1593, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(930, 79);
            this.label6.TabIndex = 6;
            this.label6.Text = "Itis P. Paleocapa | A.S. 2019/2020 ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(3844, 2119);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimilNetflix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvMovie;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbDVD;
        private System.Windows.Forms.Label lbAnno;
        private System.Windows.Forms.Label lbStato;
        private System.Windows.Forms.Label lbRegia;
        private System.Windows.Forms.Label lbProduzione;
        private System.Windows.Forms.Label lbTrama;
        private System.Windows.Forms.Label lbDurata;
        private System.Windows.Forms.Label Trama;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Durata;
        private System.Windows.Forms.Label Produzione;
        private System.Windows.Forms.Label Regia;
        private System.Windows.Forms.Label Stato;
        private System.Windows.Forms.Label Anno;
        private System.Windows.Forms.Label DVD;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList movieImageList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox NResult;
        private System.Windows.Forms.Label lbNResult;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
    }
}

