namespace Fabrika_Otomasyonu
{
    partial class gider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gider));
            dateTimePicker1 = new DateTimePicker();
            txtgiderno = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txttutar = new TextBox();
            tipi = new Label();
            cmbtip = new ComboBox();
            label1 = new Label();
            txtaciklama = new TextBox();
            dataGridView1 = new DataGridView();
            gncbtn = new Button();
            eklebtn = new Button();
            silbtn = new Button();
            listbtn = new Button();
            pictureBox1 = new PictureBox();
            anasayfabtn = new Button();
            ımageList1 = new ImageList(components);
            geribtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(818, 396);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 60;
            // 
            // txtgiderno
            // 
            txtgiderno.Location = new Point(817, 150);
            txtgiderno.Name = "txtgiderno";
            txtgiderno.ReadOnly = true;
            txtgiderno.Size = new Size(251, 27);
            txtgiderno.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(693, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 58;
            label3.Text = "Gider No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(729, 402);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 56;
            label4.Text = "Tarih:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(728, 461);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 54;
            label6.Text = "Tutar:";
            // 
            // txttutar
            // 
            txttutar.Location = new Point(817, 455);
            txttutar.Name = "txttutar";
            txttutar.Size = new Size(256, 27);
            txttutar.TabIndex = 51;
            // 
            // tipi
            // 
            tipi.AutoSize = true;
            tipi.BackColor = Color.Transparent;
            tipi.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tipi.Location = new Point(689, 207);
            tipi.Name = "tipi";
            tipi.Size = new Size(108, 21);
            tipi.TabIndex = 47;
            tipi.Text = "Gider Tipi:";
            // 
            // cmbtip
            // 
            cmbtip.FormattingEnabled = true;
            cmbtip.Items.AddRange(new object[] { "Malzeme Toplam", "Personel Maas", "Kira", "Elektrik", "Su", "Doğalgaz", "Bakım Onarım", "Vergi", "Sigorta", "Yemek", "Reklam", "Ek gider" });
            cmbtip.Location = new Point(818, 204);
            cmbtip.Name = "cmbtip";
            cmbtip.Size = new Size(250, 28);
            cmbtip.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(699, 286);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 63;
            label1.Text = "Açıklama:";
            // 
            // txtaciklama
            // 
            txtaciklama.Location = new Point(818, 280);
            txtaciklama.Multiline = true;
            txtaciklama.Name = "txtaciklama";
            txtaciklama.Size = new Size(250, 81);
            txtaciklama.TabIndex = 62;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(560, 331);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // gncbtn
            // 
            gncbtn.BackColor = Color.Bisque;
            gncbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gncbtn.Location = new Point(356, 478);
            gncbtn.Name = "gncbtn";
            gncbtn.Size = new Size(126, 59);
            gncbtn.TabIndex = 67;
            gncbtn.Text = "Düzenle";
            gncbtn.UseVisualStyleBackColor = false;
            gncbtn.Click += gncbtn_Click;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.Bisque;
            eklebtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.Location = new Point(92, 478);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(126, 57);
            eklebtn.TabIndex = 66;
            eklebtn.Text = "Yeni Gider Ekle";
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.Bisque;
            silbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.Location = new Point(488, 477);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(126, 58);
            silbtn.TabIndex = 65;
            silbtn.Text = "Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // listbtn
            // 
            listbtn.BackColor = Color.Bisque;
            listbtn.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listbtn.Location = new Point(224, 478);
            listbtn.Name = "listbtn";
            listbtn.Size = new Size(126, 58);
            listbtn.TabIndex = 64;
            listbtn.Text = "Giderleri Göster";
            listbtn.UseVisualStyleBackColor = false;
            listbtn.Click += listbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(985, 536);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // anasayfabtn
            // 
            anasayfabtn.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            anasayfabtn.ImageList = ımageList1;
            anasayfabtn.Location = new Point(80, 26);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(39, 38);
            anasayfabtn.TabIndex = 71;
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
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(40, 26);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(34, 38);
            geribtn.TabIndex = 70;
            geribtn.UseVisualStyleBackColor = true;
            geribtn.Click += geribtn_Click;
            // 
            // gider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 656);
            Controls.Add(anasayfabtn);
            Controls.Add(geribtn);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(gncbtn);
            Controls.Add(eklebtn);
            Controls.Add(silbtn);
            Controls.Add(listbtn);
            Controls.Add(label1);
            Controls.Add(txtaciklama);
            Controls.Add(cmbtip);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtgiderno);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txttutar);
            Controls.Add(tipi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "gider";
            Text = "gider";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtgiderno;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txttutar;
        private Label tipi;
        private ComboBox cmbtip;
        private Label label1;
        private TextBox txtaciklama;
        private DataGridView dataGridView1;
        private Button gncbtn;
        private Button eklebtn;
        private Button silbtn;
        private Button listbtn;
        private PictureBox pictureBox1;
        private Button anasayfabtn;
        private Button geribtn;
        private ImageList ımageList1;
    }
}