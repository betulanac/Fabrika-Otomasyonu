namespace Fabrika_Otomasyonu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtid = new TextBox();
            txtadi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtsyadi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtadres = new TextBox();
            label6 = new Label();
            txtmail = new TextBox();
            label7 = new Label();
            txtmaas = new TextBox();
            label8 = new Label();
            label9 = new Label();
            mtxtc = new MaskedTextBox();
            mtxtlfn = new MaskedTextBox();
            cboxcins = new ComboBox();
            txtpoz = new TextBox();
            label10 = new Label();
            button2 = new Button();
            silbtn = new Button();
            eklebtn = new Button();
            gnclbtn = new Button();
            arabtn = new Button();
            dataGridView1 = new DataGridView();
            geribtn = new Button();
            ımageList1 = new ImageList(components);
            txtara = new TextBox();
            pictureBox1 = new PictureBox();
            anasayfabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 75);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Personel Id:";
            label1.Click += label1_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(201, 72);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(191, 27);
            txtid.TabIndex = 1;
            // 
            // txtadi
            // 
            txtadi.Location = new Point(201, 128);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(191, 27);
            txtadi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 131);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 2;
            label2.Text = "Personel Adı:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 181);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 4;
            label3.Text = "Personel Soyadı:";
            // 
            // txtsyadi
            // 
            txtsyadi.Location = new Point(201, 182);
            txtsyadi.Name = "txtsyadi";
            txtsyadi.Size = new Size(191, 27);
            txtsyadi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 237);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 6;
            label4.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 327);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 9;
            label5.Text = "Telefon:";
            // 
            // txtadres
            // 
            txtadres.Location = new Point(201, 404);
            txtadres.Multiline = true;
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(191, 94);
            txtadres.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(121, 409);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 11;
            label6.Text = "Adres:";
            // 
            // txtmail
            // 
            txtmail.Location = new Point(201, 371);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(191, 27);
            txtmail.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(130, 376);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 13;
            label7.Text = "Mail:";
            // 
            // txtmaas
            // 
            txtmaas.Location = new Point(201, 567);
            txtmaas.Name = "txtmaas";
            txtmaas.Size = new Size(191, 27);
            txtmaas.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(123, 572);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 15;
            label8.Text = "Maaş:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(94, 511);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 17;
            label9.Text = "Pozisyon:";
            // 
            // mtxtc
            // 
            mtxtc.Location = new Point(201, 230);
            mtxtc.Mask = "00000000000";
            mtxtc.Name = "mtxtc";
            mtxtc.Size = new Size(191, 27);
            mtxtc.TabIndex = 18;
            mtxtc.ValidatingType = typeof(int);
            // 
            // mtxtlfn
            // 
            mtxtlfn.Location = new Point(201, 324);
            mtxtlfn.Mask = "(999) 000-0000";
            mtxtlfn.Name = "mtxtlfn";
            mtxtlfn.Size = new Size(191, 27);
            mtxtlfn.TabIndex = 19;
            // 
            // cboxcins
            // 
            cboxcins.FormattingEnabled = true;
            cboxcins.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cboxcins.Location = new Point(201, 278);
            cboxcins.Name = "cboxcins";
            cboxcins.Size = new Size(191, 28);
            cboxcins.TabIndex = 20;
            // 
            // txtpoz
            // 
            txtpoz.Location = new Point(201, 517);
            txtpoz.Name = "txtpoz";
            txtpoz.Size = new Size(191, 27);
            txtpoz.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(101, 286);
            label10.Name = "label10";
            label10.Size = new Size(71, 17);
            label10.TabIndex = 22;
            label10.Text = "Cinsiyet:";
            label10.Click += label10_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(575, 511);
            button2.Name = "button2";
            button2.Size = new Size(149, 35);
            button2.TabIndex = 24;
            button2.Text = "Personeli Listele";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.RosyBrown;
            silbtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.Location = new Point(575, 554);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(149, 35);
            silbtn.TabIndex = 25;
            silbtn.Text = "Personeli Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.RosyBrown;
            eklebtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.Location = new Point(760, 511);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(160, 35);
            eklebtn.TabIndex = 26;
            eklebtn.Text = "Yeni Personel Ekle";
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // gnclbtn
            // 
            gnclbtn.BackColor = Color.RosyBrown;
            gnclbtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gnclbtn.Location = new Point(760, 554);
            gnclbtn.Name = "gnclbtn";
            gnclbtn.Size = new Size(160, 35);
            gnclbtn.TabIndex = 27;
            gnclbtn.Text = "Bilgileri Güncelle";
            gnclbtn.UseVisualStyleBackColor = false;
            gnclbtn.Click += gnclbtn_Click;
            // 
            // arabtn
            // 
            arabtn.BackColor = Color.RosyBrown;
            arabtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            arabtn.Location = new Point(983, 128);
            arabtn.Name = "arabtn";
            arabtn.Size = new Size(80, 35);
            arabtn.TabIndex = 28;
            arabtn.Text = "Ara";
            arabtn.UseVisualStyleBackColor = false;
            arabtn.Click += arabtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(512, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(551, 302);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // geribtn
            // 
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(39, 21);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(34, 38);
            geribtn.TabIndex = 30;
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
            ımageList1.Images.SetKeyName(2, "Ekran görüntüsü 2024-01-07 133614.png");
            // 
            // txtara
            // 
            txtara.Location = new Point(760, 136);
            txtara.Name = "txtara";
            txtara.Size = new Size(191, 27);
            txtara.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(984, 536);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // anasayfabtn
            // 
            anasayfabtn.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            anasayfabtn.ImageList = ımageList1;
            anasayfabtn.Location = new Point(79, 21);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(39, 38);
            anasayfabtn.TabIndex = 68;
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1144, 661);
            Controls.Add(anasayfabtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtara);
            Controls.Add(geribtn);
            Controls.Add(dataGridView1);
            Controls.Add(arabtn);
            Controls.Add(gnclbtn);
            Controls.Add(eklebtn);
            Controls.Add(silbtn);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(txtpoz);
            Controls.Add(cboxcins);
            Controls.Add(mtxtlfn);
            Controls.Add(mtxtc);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtmaas);
            Controls.Add(label6);
            Controls.Add(txtmail);
            Controls.Add(label5);
            Controls.Add(txtadres);
            Controls.Add(txtsyadi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtadi);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "prsnlekle";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid;
        private TextBox txtadi;
        private Label label2;
        private Label label3;
        private TextBox txtsyadi;
        private Label label4;
        private Label label5;
        private TextBox txtadres;
        private Label label6;
        private TextBox txtmail;
        private Label label7;
        private TextBox txtmaas;
        private Label label8;
        private Label label9;
        private MaskedTextBox mtxtc;
        private MaskedTextBox mtxtlfn;
        private ComboBox cboxcins;
        private TextBox txtpoz;
        private Label label10;
        private Button button2;
        private Button silbtn;
        private Button eklebtn;
        private Button gnclbtn;
        private Button arabtn;
        private DataGridView dataGridView1;
        private Button geribtn;
        private TextBox txtara;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private Button anasayfabtn;
    }
}