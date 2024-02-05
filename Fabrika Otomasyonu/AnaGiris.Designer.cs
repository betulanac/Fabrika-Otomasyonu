namespace Fabrika_Otomasyonu
{
    partial class AnaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            button1 = new Button();
            yntmbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Font = new Font("Rockwell Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(398, 426);
            button1.Name = "button1";
            button1.Size = new Size(171, 71);
            button1.TabIndex = 0;
            button1.Text = "Personel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yntmbtn
            // 
            yntmbtn.BackColor = Color.Sienna;
            yntmbtn.Font = new Font("Rockwell Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            yntmbtn.ForeColor = SystemColors.ButtonHighlight;
            yntmbtn.Location = new Point(398, 338);
            yntmbtn.Name = "yntmbtn";
            yntmbtn.Size = new Size(171, 67);
            yntmbtn.TabIndex = 1;
            yntmbtn.Text = "Yönetim";
            yntmbtn.UseVisualStyleBackColor = false;
            yntmbtn.Click += yntmbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(866, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AnaGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1145, 659);
            Controls.Add(pictureBox1);
            Controls.Add(yntmbtn);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AnaGiris";
            Text = "AnaGiris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button yntmbtn;
        private PictureBox pictureBox1;
    }
}