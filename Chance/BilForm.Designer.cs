namespace Chance
{
    partial class BilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilForm));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.הטפסים = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCheckWin = new System.Windows.Forms.Button();
            this.lblResultWin = new System.Windows.Forms.Label();
            this.lblAle = new System.Windows.Forms.Label();
            this.lblLev = new System.Windows.Forms.Label();
            this.lblYalom = new System.Windows.Forms.Label();
            this.lblTiltan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // הטפסים
            // 
            this.הטפסים.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.הטפסים.FormattingEnabled = true;
            this.הטפסים.ItemHeight = 20;
            this.הטפסים.Location = new System.Drawing.Point(34, 36);
            this.הטפסים.Name = "הטפסים";
            this.הטפסים.Size = new System.Drawing.Size(330, 184);
            this.הטפסים.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(119, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "טפסים שנשלחו";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(260, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(320, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btnCheckWin
            // 
            this.btnCheckWin.BackColor = System.Drawing.Color.MintCream;
            this.btnCheckWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCheckWin.ForeColor = System.Drawing.Color.Green;
            this.btnCheckWin.Location = new System.Drawing.Point(290, 364);
            this.btnCheckWin.Name = "btnCheckWin";
            this.btnCheckWin.Size = new System.Drawing.Size(109, 40);
            this.btnCheckWin.TabIndex = 8;
            this.btnCheckWin.Text = "בדיקת טופס";
            this.btnCheckWin.UseVisualStyleBackColor = false;
            this.btnCheckWin.Click += new System.EventHandler(this.btnCheckWin_Click);
            // 
            // lblResultWin
            // 
            this.lblResultWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResultWin.ForeColor = System.Drawing.Color.Green;
            this.lblResultWin.Location = new System.Drawing.Point(31, 357);
            this.lblResultWin.Name = "lblResultWin";
            this.lblResultWin.Size = new System.Drawing.Size(235, 57);
            this.lblResultWin.TabIndex = 9;
            this.lblResultWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAle
            // 
            this.lblAle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAle.Location = new System.Drawing.Point(34, 272);
            this.lblAle.Name = "lblAle";
            this.lblAle.Size = new System.Drawing.Size(44, 23);
            this.lblAle.TabIndex = 10;
            this.lblAle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLev
            // 
            this.lblLev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLev.Location = new System.Drawing.Point(94, 272);
            this.lblLev.Name = "lblLev";
            this.lblLev.Size = new System.Drawing.Size(47, 23);
            this.lblLev.TabIndex = 11;
            this.lblLev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYalom
            // 
            this.lblYalom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYalom.Location = new System.Drawing.Point(260, 272);
            this.lblYalom.Name = "lblYalom";
            this.lblYalom.Size = new System.Drawing.Size(44, 23);
            this.lblYalom.TabIndex = 12;
            this.lblYalom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiltan
            // 
            this.lblTiltan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTiltan.Location = new System.Drawing.Point(320, 272);
            this.lblTiltan.Name = "lblTiltan";
            this.lblTiltan.Size = new System.Drawing.Size(44, 23);
            this.lblTiltan.TabIndex = 13;
            this.lblTiltan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(129, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "תוצאה הגרלה אחרונה";
            // 
            // BilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTiltan);
            this.Controls.Add(this.lblYalom);
            this.Controls.Add(this.lblLev);
            this.Controls.Add(this.lblAle);
            this.Controls.Add(this.lblResultWin);
            this.Controls.Add(this.btnCheckWin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.הטפסים);
            this.Name = "BilForm";
            this.Text = "BilForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListBox הטפסים;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCheckWin;
        private System.Windows.Forms.Label lblResultWin;
        private System.Windows.Forms.Label lblAle;
        private System.Windows.Forms.Label lblLev;
        private System.Windows.Forms.Label lblYalom;
        private System.Windows.Forms.Label lblTiltan;
        private System.Windows.Forms.Label label2;
    }
}