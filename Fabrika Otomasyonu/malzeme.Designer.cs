namespace Fabrika_Otomasyonu
{
    partial class malzeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(malzeme));
            label10 = new Label();
            tarih = new Label();
            label5 = new Label();
            txtstok = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtadi = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            txtfiyat = new TextBox();
            txtmarka = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            arabtn = new Button();
            gnclbtn = new Button();
            eklebtn = new Button();
            silbtn = new Button();
            listbtn = new Button();
            txtarama = new TextBox();
            pictureBox1 = new PictureBox();
            stkbtn = new Button();
            geribtn = new Button();
            ımageList1 = new ImageList(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(146, 221);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 38;
            label10.Text = "Marka:";
            // 
            // tarih
            // 
            tarih.AutoSize = true;
            tarih.BackColor = Color.Transparent;
            tarih.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tarih.Location = new Point(67, 335);
            tarih.Name = "tarih";
            tarih.Size = new Size(151, 21);
            tarih.TabIndex = 33;
            tarih.Text = "Eklenme Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(116, 382);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 31;
            // 
            // txtstok
            // 
            txtstok.Location = new Point(229, 393);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(234, 27);
            txtstok.TabIndex = 29;
            txtstok.TextChanged += txtstok_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 278);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 28;
            label4.Text = "Birim Fiyat (kg):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 399);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 27;
            label3.Text = "Stok (kg):";
            // 
            // txtadi
            // 
            txtadi.Location = new Point(229, 160);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(234, 27);
            txtadi.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 166);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 25;
            label2.Text = "Malzeme Adı:";
            // 
            // txtid
            // 
            txtid.Location = new Point(229, 104);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(234, 27);
            txtid.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 110);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 23;
            label1.Text = "Malzeme Id:";
            // 
            // txtfiyat
            // 
            txtfiyat.Location = new Point(229, 275);
            txtfiyat.Name = "txtfiyat";
            txtfiyat.Size = new Size(234, 27);
            txtfiyat.TabIndex = 39;
            // 
            // txtmarka
            // 
            txtmarka.Location = new Point(229, 215);
            txtmarka.Name = "txtmarka";
            txtmarka.Size = new Size(234, 27);
            txtmarka.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(229, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 27);
            dateTimePicker1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(529, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(551, 302);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // arabtn
            // 
            arabtn.BackColor = Color.PeachPuff;
            arabtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            arabtn.Location = new Point(990, 76);
            arabtn.Name = "arabtn";
            arabtn.Size = new Size(77, 35);
            arabtn.TabIndex = 46;
            arabtn.Text = "Ara";
            arabtn.UseVisualStyleBackColor = false;
            arabtn.Click += arabtn_Click;
            // 
            // gnclbtn
            // 
            gnclbtn.BackColor = Color.PeachPuff;
            gnclbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gnclbtn.Location = new Point(795, 485);
            gnclbtn.Name = "gnclbtn";
            gnclbtn.Size = new Size(160, 51);
            gnclbtn.TabIndex = 45;
            gnclbtn.Text = "Bilgileri Güncelle";
            gnclbtn.UseVisualStyleBackColor = false;
            gnclbtn.Click += gnclbtn_Click;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.PeachPuff;
            eklebtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.Location = new Point(574, 553);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(159, 53);
            eklebtn.TabIndex = 44;
            eklebtn.Text = "Yeni Malzeme Ekle";
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.PeachPuff;
            silbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.Location = new Point(795, 553);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(160, 53);
            silbtn.TabIndex = 43;
            silbtn.Text = "Malzemeyi Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // listbtn
            // 
            listbtn.BackColor = Color.PeachPuff;
            listbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listbtn.Location = new Point(574, 485);
            listbtn.Name = "listbtn";
            listbtn.Size = new Size(159, 51);
            listbtn.TabIndex = 42;
            listbtn.Text = "Malzemeleri Listele";
            listbtn.UseVisualStyleBackColor = false;
            listbtn.Click += listbtn_Click;
            // 
            // txtarama
            // 
            txtarama.Location = new Point(692, 80);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(234, 27);
            txtarama.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(987, 538);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // stkbtn
            // 
            stkbtn.BackColor = Color.PeachPuff;
            stkbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            stkbtn.Location = new Point(291, 451);
            stkbtn.Name = "stkbtn";
            stkbtn.Size = new Size(124, 55);
            stkbtn.TabIndex = 51;
            stkbtn.Text = "Stok Güncelle";
            stkbtn.UseVisualStyleBackColor = false;
            stkbtn.Click += stkbtn_Click;
            // 
            // geribtn
            // 
            geribtn.BackColor = Color.DarkSalmon;
            geribtn.BackgroundImageLayout = ImageLayout.Stretch;
            geribtn.ForeColor = SystemColors.ControlDarkDark;
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(38, 21);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(40, 46);
            geribtn.TabIndex = 52;
            geribtn.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(89, 21);
            button1.Name = "button1";
            button1.Size = new Size(40, 46);
            button1.TabIndex = 53;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // malzeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1147, 662);
            Controls.Add(button1);
            Controls.Add(geribtn);
            Controls.Add(stkbtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtarama);
            Controls.Add(dataGridView1);
            Controls.Add(arabtn);
            Controls.Add(gnclbtn);
            Controls.Add(eklebtn);
            Controls.Add(silbtn);
            Controls.Add(listbtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtmarka);
            Controls.Add(txtfiyat);
            Controls.Add(label10);
            Controls.Add(tarih);
            Controls.Add(label5);
            Controls.Add(txtstok);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtadi);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "malzeme";
            Text = "malzeme";
            Load += malzeme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label tarih;
        private Label label5;
        private TextBox txtstok;
        private Label label4;
        private Label label3;
        private TextBox txtadi;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private TextBox txtfiyat;
        private TextBox txtmarka;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button arabtn;
        private Button gnclbtn;
        private Button eklebtn;
        private Button silbtn;
        private Button listbtn;
        private TextBox txtarama;
        private PictureBox pictureBox1;
        private Button stkbtn;
        private Button geribtn;
        private ImageList ımageList1;
        private Button button1;
    }
}