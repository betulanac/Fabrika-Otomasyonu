namespace Fabrika_Otomasyonu
{
    partial class musteribilggoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteribilggoruntule));
            mxttlfn = new MaskedTextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtmail = new TextBox();
            txtadres = new TextBox();
            txtadi = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            arabtn = new Button();
            gncbtn = new Button();
            eklebtn = new Button();
            silbtn = new Button();
            listbtn = new Button();
            dataGridView1 = new DataGridView();
            txtara = new TextBox();
            pictureBox1 = new PictureBox();
            anasayfabtn = new Button();
            ımageList1 = new ImageList(components);
            geribtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mxttlfn
            // 
            mxttlfn.Location = new Point(191, 280);
            mxttlfn.Mask = "(999) 000-0000";
            mxttlfn.Name = "mxttlfn";
            mxttlfn.Size = new Size(191, 27);
            mxttlfn.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(93, 283);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 32;
            label5.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(113, 351);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 31;
            label7.Text = "Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(104, 427);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 30;
            label6.Text = "Adres:";
            // 
            // txtmail
            // 
            txtmail.Location = new Point(191, 338);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(191, 27);
            txtmail.TabIndex = 29;
            // 
            // txtadres
            // 
            txtadres.Location = new Point(191, 414);
            txtadres.Multiline = true;
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(191, 94);
            txtadres.TabIndex = 28;
            // 
            // txtadi
            // 
            txtadi.Location = new Point(191, 207);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(191, 27);
            txtadi.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 207);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 26;
            label2.Text = "Şirket Adı:";
            // 
            // txtid
            // 
            txtid.Location = new Point(191, 151);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(191, 27);
            txtid.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 151);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 24;
            label1.Text = "Şirket Id:";
            // 
            // arabtn
            // 
            arabtn.BackColor = Color.Bisque;
            arabtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            arabtn.Location = new Point(953, 82);
            arabtn.Name = "arabtn";
            arabtn.Size = new Size(126, 35);
            arabtn.TabIndex = 39;
            arabtn.Text = "Ara";
            arabtn.UseVisualStyleBackColor = false;
            arabtn.Click += arabtn_Click;
            // 
            // gncbtn
            // 
            gncbtn.BackColor = Color.Bisque;
            gncbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gncbtn.Location = new Point(788, 499);
            gncbtn.Name = "gncbtn";
            gncbtn.Size = new Size(126, 52);
            gncbtn.TabIndex = 38;
            gncbtn.Text = "Bilgileri Güncelle";
            gncbtn.UseVisualStyleBackColor = false;
            gncbtn.Click += gncbtn_Click;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.Bisque;
            eklebtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.Location = new Point(566, 499);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(139, 52);
            eklebtn.TabIndex = 37;
            eklebtn.Text = "Yeni Müşteri Ekle";
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.Bisque;
            silbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.Location = new Point(788, 441);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(126, 50);
            silbtn.TabIndex = 36;
            silbtn.Text = "Bilgileri Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // listbtn
            // 
            listbtn.BackColor = Color.Bisque;
            listbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listbtn.Location = new Point(566, 443);
            listbtn.Name = "listbtn";
            listbtn.Size = new Size(139, 50);
            listbtn.TabIndex = 35;
            listbtn.Text = "Müterileri Listele";
            listbtn.UseVisualStyleBackColor = false;
            listbtn.Click += listbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(478, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(601, 249);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // txtara
            // 
            txtara.Location = new Point(723, 86);
            txtara.Name = "txtara";
            txtara.Size = new Size(191, 27);
            txtara.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(988, 541);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // anasayfabtn
            // 
            anasayfabtn.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            anasayfabtn.ImageList = ımageList1;
            anasayfabtn.Location = new Point(104, 26);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(38, 40);
            anasayfabtn.TabIndex = 44;
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Ekran görüntüsü 2024-01-06 145239.png");
            ımageList1.Images.SetKeyName(1, "Ekran görüntüsü 2024-01-06 173045.png");
            // 
            // geribtn
            // 
            geribtn.BackColor = Color.DarkSalmon;
            geribtn.BackgroundImageLayout = ImageLayout.Stretch;
            geribtn.ForeColor = SystemColors.ControlDarkDark;
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(51, 26);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(37, 40);
            geribtn.TabIndex = 43;
            geribtn.UseVisualStyleBackColor = false;
            geribtn.Click += geribtn_Click;
            // 
            // musteribilggoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1147, 660);
            Controls.Add(anasayfabtn);
            Controls.Add(geribtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtara);
            Controls.Add(dataGridView1);
            Controls.Add(arabtn);
            Controls.Add(gncbtn);
            Controls.Add(eklebtn);
            Controls.Add(silbtn);
            Controls.Add(listbtn);
            Controls.Add(mxttlfn);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtmail);
            Controls.Add(txtadres);
            Controls.Add(txtadi);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "musteribilggoruntule";
            Text = "musteribilggoruntule";
            Load += musteribilggoruntule_Load;
            MouseClick += musteribilggoruntule_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox mxttlfn;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txtmail;
        private TextBox txtadres;
        private TextBox txtadi;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private Button arabtn;
        private Button gncbtn;
        private Button eklebtn;
        private Button silbtn;
        private Button listbtn;
        private DataGridView dataGridView1;
        private TextBox txtara;
        private PictureBox pictureBox1;
        private Button anasayfabtn;
        private ImageList ımageList1;
        private Button geribtn;
    }
}