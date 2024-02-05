namespace Fabrika_Otomasyonu
{
    partial class cikolata
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cikolata));
            txtadi = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            arabtn = new Button();
            button5 = new Button();
            eklebtn = new Button();
            silbtn = new Button();
            listbtn = new Button();
            nstok = new NumericUpDown();
            txtara = new TextBox();
            pictureBox1 = new PictureBox();
            txtfiyat = new TextBox();
            label5 = new Label();
            geribtn = new Button();
            ımageList1 = new ImageList(components);
            anabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nstok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtadi
            // 
            txtadi.Location = new Point(229, 166);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(191, 27);
            txtadi.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 169);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 30;
            label2.Text = "Çikolata Adı:";
            // 
            // txtid
            // 
            txtid.Location = new Point(229, 107);
            txtid.Name = "txtid";
            txtid.Size = new Size(191, 27);
            txtid.TabIndex = 29;
            txtid.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 113);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 28;
            label1.Text = "Çikolata Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(150, 246);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 32;
            label4.Text = " Stok:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(517, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(545, 304);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // arabtn
            // 
            arabtn.BackColor = Color.MistyRose;
            arabtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            arabtn.Location = new Point(987, 113);
            arabtn.Name = "arabtn";
            arabtn.Size = new Size(75, 37);
            arabtn.TabIndex = 45;
            arabtn.Text = "Ara";
            arabtn.UseVisualStyleBackColor = false;
            arabtn.Click += arabtn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(184, 487);
            button5.Name = "button5";
            button5.Size = new Size(200, 37);
            button5.TabIndex = 44;
            button5.Text = "Bigileri Güncelle";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.MistyRose;
            eklebtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.Location = new Point(184, 406);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(200, 32);
            eklebtn.TabIndex = 43;
            eklebtn.Text = "Yeni Çikolata Ekle";
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.MistyRose;
            silbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.Location = new Point(184, 530);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(200, 32);
            silbtn.TabIndex = 42;
            silbtn.Text = "Veriyi Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // listbtn
            // 
            listbtn.BackColor = Color.MistyRose;
            listbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listbtn.Location = new Point(184, 444);
            listbtn.Name = "listbtn";
            listbtn.Size = new Size(200, 37);
            listbtn.TabIndex = 41;
            listbtn.Text = "Verileri Listele";
            listbtn.UseVisualStyleBackColor = false;
            listbtn.Click += listbtn_Click;
            // 
            // nstok
            // 
            nstok.Location = new Point(229, 240);
            nstok.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nstok.Name = "nstok";
            nstok.Size = new Size(191, 27);
            nstok.TabIndex = 47;
            // 
            // txtara
            // 
            txtara.Location = new Point(790, 123);
            txtara.Name = "txtara";
            txtara.Size = new Size(191, 27);
            txtara.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(985, 540);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // txtfiyat
            // 
            txtfiyat.Location = new Point(229, 308);
            txtfiyat.Name = "txtfiyat";
            txtfiyat.Size = new Size(191, 27);
            txtfiyat.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(101, 308);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 50;
            label5.Text = "Birim Fiyat:";
            // 
            // geribtn
            // 
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(46, 23);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(49, 39);
            geribtn.TabIndex = 52;
            geribtn.UseVisualStyleBackColor = true;
            geribtn.Click += geribtn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Ekran görüntüsü 2024-01-06 145239.png");
            ımageList1.Images.SetKeyName(1, "Ekran görüntüsü 2024-01-06 173045.png");
            // 
            // anabtn
            // 
            anabtn.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            anabtn.ImageList = ımageList1;
            anabtn.Location = new Point(101, 23);
            anabtn.Name = "anabtn";
            anabtn.Size = new Size(43, 39);
            anabtn.TabIndex = 53;
            anabtn.UseVisualStyleBackColor = true;
            anabtn.Click += anabtn_Click;
            // 
            // cikolata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 659);
            Controls.Add(anabtn);
            Controls.Add(geribtn);
            Controls.Add(txtfiyat);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtara);
            Controls.Add(nstok);
            Controls.Add(dataGridView1);
            Controls.Add(arabtn);
            Controls.Add(button5);
            Controls.Add(eklebtn);
            Controls.Add(silbtn);
            Controls.Add(listbtn);
            Controls.Add(label4);
            Controls.Add(txtadi);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "cikolata";
            Text = "cikolata";
            Load += cikolata_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nstok).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtadi;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private Label label4;
        private DataGridView dataGridView1;
        private Button arabtn;
        private Button button5;
        private Button eklebtn;
        private Button silbtn;
        private Button listbtn;
        private NumericUpDown nstok;
        private TextBox txtara;
        private PictureBox pictureBox1;
        private TextBox txtfiyat;
        private Label label5;
        private Button geribtn;
        private ImageList ımageList1;
        private Button anabtn;
    }
}