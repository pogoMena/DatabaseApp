
namespace Lab5b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstEpisode = new System.Windows.Forms.TextBox();
            this.pbDoctor = new System.Windows.Forms.PictureBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbSeries = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbActor = new System.Windows.Forms.TextBox();
            this.lAgeStart = new System.Windows.Forms.Label();
            this.lSeries = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lActor = new System.Windows.Forms.Label();
            this.lDoctor = new System.Windows.Forms.Label();
            this.dbDoctor = new System.Windows.Forms.ComboBox();
            this.lbCompanions = new System.Windows.Forms.ListBox();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbLinq = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).BeginInit();
            this.gbMethod.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.label1);
            this.gbDoctor.Controls.Add(this.tbFirstEpisode);
            this.gbDoctor.Controls.Add(this.pbDoctor);
            this.gbDoctor.Controls.Add(this.tbYear);
            this.gbDoctor.Controls.Add(this.tbSeries);
            this.gbDoctor.Controls.Add(this.tbAge);
            this.gbDoctor.Controls.Add(this.tbActor);
            this.gbDoctor.Controls.Add(this.lAgeStart);
            this.gbDoctor.Controls.Add(this.lSeries);
            this.gbDoctor.Controls.Add(this.lYear);
            this.gbDoctor.Controls.Add(this.lActor);
            this.gbDoctor.Controls.Add(this.lDoctor);
            this.gbDoctor.Controls.Add(this.dbDoctor);
            this.gbDoctor.Location = new System.Drawing.Point(43, 37);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(337, 393);
            this.gbDoctor.TabIndex = 0;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "The Doctor";
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First full episode";
            // 
            // tbFirstEpisode
            // 
            this.tbFirstEpisode.Location = new System.Drawing.Point(22, 364);
            this.tbFirstEpisode.Name = "tbFirstEpisode";
            this.tbFirstEpisode.Size = new System.Drawing.Size(286, 20);
            this.tbFirstEpisode.TabIndex = 11;
            // 
            // pbDoctor
            // 
            this.pbDoctor.Location = new System.Drawing.Point(148, 126);
            this.pbDoctor.Name = "pbDoctor";
            this.pbDoctor.Size = new System.Drawing.Size(160, 232);
            this.pbDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoctor.TabIndex = 10;
            this.pbDoctor.TabStop = false;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(81, 126);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(61, 20);
            this.tbYear.TabIndex = 9;
            // 
            // tbSeries
            // 
            this.tbSeries.Location = new System.Drawing.Point(81, 178);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(61, 20);
            this.tbSeries.TabIndex = 8;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(81, 220);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(61, 20);
            this.tbAge.TabIndex = 7;
            // 
            // tbActor
            // 
            this.tbActor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbActor.Location = new System.Drawing.Point(81, 87);
            this.tbActor.Name = "tbActor";
            this.tbActor.ReadOnly = true;
            this.tbActor.Size = new System.Drawing.Size(227, 20);
            this.tbActor.TabIndex = 6;
            this.tbActor.Text = "placeHolder";
            // 
            // lAgeStart
            // 
            this.lAgeStart.AutoSize = true;
            this.lAgeStart.Location = new System.Drawing.Point(19, 223);
            this.lAgeStart.Name = "lAgeStart";
            this.lAgeStart.Size = new System.Drawing.Size(67, 13);
            this.lAgeStart.TabIndex = 5;
            this.lAgeStart.Text = "Age at start: ";
            // 
            // lSeries
            // 
            this.lSeries.AutoSize = true;
            this.lSeries.Location = new System.Drawing.Point(19, 181);
            this.lSeries.Name = "lSeries";
            this.lSeries.Size = new System.Drawing.Size(42, 13);
            this.lSeries.TabIndex = 4;
            this.lSeries.Text = "Series: ";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(19, 129);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(35, 13);
            this.lYear.TabIndex = 3;
            this.lYear.Text = "Year: ";
            // 
            // lActor
            // 
            this.lActor.AutoSize = true;
            this.lActor.Location = new System.Drawing.Point(19, 90);
            this.lActor.Name = "lActor";
            this.lActor.Size = new System.Drawing.Size(59, 13);
            this.lActor.TabIndex = 2;
            this.lActor.Text = "Played by: ";
            // 
            // lDoctor
            // 
            this.lDoctor.AutoSize = true;
            this.lDoctor.Location = new System.Drawing.Point(19, 40);
            this.lDoctor.Name = "lDoctor";
            this.lDoctor.Size = new System.Drawing.Size(45, 13);
            this.lDoctor.TabIndex = 1;
            this.lDoctor.Text = "Doctor: ";
            // 
            // dbDoctor
            // 
            this.dbDoctor.FormattingEnabled = true;
            this.dbDoctor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.dbDoctor.Location = new System.Drawing.Point(81, 37);
            this.dbDoctor.Name = "dbDoctor";
            this.dbDoctor.Size = new System.Drawing.Size(227, 21);
            this.dbDoctor.TabIndex = 0;
            this.dbDoctor.SelectedIndexChanged += new System.EventHandler(this.dbDoctor_SelectedIndexChanged);
            // 
            // lbCompanions
            // 
            this.lbCompanions.FormattingEnabled = true;
            this.lbCompanions.Location = new System.Drawing.Point(443, 45);
            this.lbCompanions.Name = "lbCompanions";
            this.lbCompanions.Size = new System.Drawing.Size(329, 381);
            this.lbCompanions.TabIndex = 1;
            // 
            // gbMethod
            // 
            this.gbMethod.Controls.Add(this.rbSQL);
            this.gbMethod.Controls.Add(this.rbLinq);
            this.gbMethod.Location = new System.Drawing.Point(791, 344);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(202, 82);
            this.gbMethod.TabIndex = 2;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "Solve Using:";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Checked = true;
            this.rbSQL.Location = new System.Drawing.Point(27, 34);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(46, 17);
            this.rbSQL.TabIndex = 3;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "SQL";
            this.rbSQL.UseVisualStyleBackColor = true;
            // 
            // rbLinq
            // 
            this.rbLinq.AutoSize = true;
            this.rbLinq.Location = new System.Drawing.Point(27, 57);
            this.rbLinq.Name = "rbLinq";
            this.rbLinq.Size = new System.Drawing.Size(45, 17);
            this.rbLinq.TabIndex = 4;
            this.rbLinq.Text = "Linq";
            this.rbLinq.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(791, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 293);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.lbCompanions);
            this.Controls.Add(this.gbDoctor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).EndInit();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.Label lDoctor;
        private System.Windows.Forms.ComboBox dbDoctor;
        private System.Windows.Forms.Label lAgeStart;
        private System.Windows.Forms.Label lSeries;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lActor;
        private System.Windows.Forms.TextBox tbActor;
        private System.Windows.Forms.ListBox lbCompanions;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbSeries;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.PictureBox pbDoctor;
        private System.Windows.Forms.TextBox tbFirstEpisode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbLinq;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

