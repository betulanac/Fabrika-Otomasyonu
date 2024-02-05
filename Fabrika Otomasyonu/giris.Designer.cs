namespace Fabrika_Otomasyonu
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtkuladi = new TextBox();
            txtsifre = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            geribtn = new Button();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            anasayfabtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(540, 475);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(256, 376);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(314, 424);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txtkuladi
            // 
            txtkuladi.Location = new Point(386, 376);
            txtkuladi.Name = "txtkuladi";
            txtkuladi.Size = new Size(263, 27);
            txtkuladi.TabIndex = 3;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(386, 427);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(263, 27);
            txtsifre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rockwell Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(281, 323);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 6;
            label4.Text = "Depatman:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Üretim", "Depo", "Satış ve Pazarlama", "İnsan Kaynakları ve Muhasebe" });
            comboBox1.Location = new Point(386, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 28);
            comboBox1.TabIndex = 7;
            // 
            // geribtn
            // 
            geribtn.BackColor = Color.DarkSalmon;
            geribtn.BackgroundImageLayout = ImageLayout.Stretch;
            geribtn.ForeColor = SystemColors.ControlDarkDark;
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList1;
            geribtn.Location = new Point(66, 45);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(37, 40);
            geribtn.TabIndex = 8;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(959, 518);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // anasayfabtn
            // 
            anasayfabtn.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            anasayfabtn.ImageList = ımageList1;
            anasayfabtn.Location = new Point(119, 45);
            anasayfabtn.Name = "anasayfabtn";
            anasayfabtn.Size = new Size(38, 40);
            anasayfabtn.TabIndex = 10;
            anasayfabtn.UseVisualStyleBackColor = true;
            anasayfabtn.Click += anasayfabtn_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 658);
            Controls.Add(anasayfabtn);
            Controls.Add(pictureBox1);
            Controls.Add(geribtn);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(txtsifre);
            Controls.Add(txtkuladi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "giris";
            Text = "prsnlgiris";
            Load += prsnlGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtkuladi;
        private TextBox txtsifre;
        private Label label4;
        private ComboBox comboBox1;
        private Button geribtn;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
        private Button anasayfabtn;
    }
}