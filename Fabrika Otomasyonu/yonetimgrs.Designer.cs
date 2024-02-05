namespace Fabrika_Otomasyonu
{
    partial class yonetimgrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetimgrs));
            txtsifre = new TextBox();
            txtkuladi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            geribtn = new Button();
            ımageList2 = new ImageList(components);
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(457, 422);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(263, 27);
            txtsifre.TabIndex = 9;
            // 
            // txtkuladi
            // 
            txtkuladi.Location = new Point(457, 371);
            txtkuladi.Name = "txtkuladi";
            txtkuladi.Size = new Size(263, 27);
            txtkuladi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(393, 427);
            label2.Name = "label2";
            label2.Size = new Size(58, 22);
            label2.TabIndex = 7;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(317, 371);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı:";
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Rockwell Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(626, 471);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 5;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // geribtn
            // 
            geribtn.ImageKey = "Ekran görüntüsü 2024-01-06 145239.png";
            geribtn.ImageList = ımageList2;
            geribtn.Location = new Point(66, 44);
            geribtn.Name = "geribtn";
            geribtn.Size = new Size(40, 38);
            geribtn.TabIndex = 10;
            geribtn.UseVisualStyleBackColor = true;
            geribtn.Click += geribtn_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth8Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "Ekran görüntüsü 2024-01-06 145239.png");
            ımageList2.Images.SetKeyName(1, "Ekran görüntüsü 2024-01-06 173045.png");
            // 
            // button2
            // 
            button2.ImageKey = "Ekran görüntüsü 2024-01-06 173045.png";
            button2.ImageList = ımageList2;
            button2.Location = new Point(123, 44);
            button2.Name = "button2";
            button2.Size = new Size(40, 38);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(958, 517);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // yonetimgrs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 658);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(geribtn);
            Controls.Add(txtsifre);
            Controls.Add(txtkuladi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ImeMode = ImeMode.Off;
            Name = "yonetimgrs";
            Text = "yonetimgrs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsifre;
        private TextBox txtkuladi;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button geribtn;
        private ImageList ımageList2;
        private Button button2;
        private PictureBox pictureBox1;
    }
}