﻿namespace Chance
{
    partial class SignUP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblResultuser = new System.Windows.Forms.Label();
            this.lblresultpass = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "הרשמה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(223, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "שם משתמש";
            this.toolTip1.SetToolTip(this.label2, "חייב להתחיל באות גדולה,מינימום שתי תווים");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(247, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "סיסמא";
            this.toolTip1.SetToolTip(this.label3, "מינימום 6 תווים");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // lblResultuser
            // 
            this.lblResultuser.AutoSize = true;
            this.lblResultuser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultuser.ForeColor = System.Drawing.Color.Navy;
            this.lblResultuser.Location = new System.Drawing.Point(4, 100);
            this.lblResultuser.Name = "lblResultuser";
            this.lblResultuser.Size = new System.Drawing.Size(47, 13);
            this.lblResultuser.TabIndex = 3;
            this.lblResultuser.Text = "Check...";
            // 
            // lblresultpass
            // 
            this.lblresultpass.AutoSize = true;
            this.lblresultpass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblresultpass.ForeColor = System.Drawing.Color.Navy;
            this.lblresultpass.Location = new System.Drawing.Point(4, 184);
            this.lblresultpass.Name = "lblresultpass";
            this.lblresultpass.Size = new System.Drawing.Size(47, 13);
            this.lblresultpass.TabIndex = 3;
            this.lblresultpass.Text = "Check...";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignUp.ForeColor = System.Drawing.Color.Navy;
            this.btnSignUp.Location = new System.Drawing.Point(83, 249);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(105, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "הרשמה";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 304);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblresultpass);
            this.Controls.Add(this.lblResultuser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUP";
            this.Text = "SignUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResultuser;
        private System.Windows.Forms.Label lblresultpass;
        private System.Windows.Forms.Button btnSignUp;
    }
}