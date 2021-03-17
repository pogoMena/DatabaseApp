
namespace Lab5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bucket = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.waterSpeed = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bClose = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(97, 146);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(108, 61);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bucket
            // 
            this.bucket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bucket.Location = new System.Drawing.Point(158, 207);
            this.bucket.Margin = new System.Windows.Forms.Padding(0);
            this.bucket.Name = "bucket";
            this.bucket.Size = new System.Drawing.Size(257, 186);
            this.bucket.TabIndex = 1;
            this.bucket.Paint += new System.Windows.Forms.PaintEventHandler(this.bucket_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // waterSpeed
            // 
            this.waterSpeed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.waterSpeed.Location = new System.Drawing.Point(78, 80);
            this.waterSpeed.Maximum = 1000;
            this.waterSpeed.Minimum = 50;
            this.waterSpeed.Name = "waterSpeed";
            this.waterSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.waterSpeed.Size = new System.Drawing.Size(104, 45);
            this.waterSpeed.TabIndex = 2;
            this.waterSpeed.Value = 1000;
            this.waterSpeed.Scroll += new System.EventHandler(this.waterSpeed_Scroll);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Aqua;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(210, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(97, 12);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 23);
            this.bColor.TabIndex = 4;
            this.bColor.Text = "Color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 440);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.waterSpeed);
            this.Controls.Add(this.bucket);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bucket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar waterSpeed;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bColor;
    }
}

