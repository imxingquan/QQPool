﻿namespace TQ
{
    partial class RegsterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.unameTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册邀请码";
            // 
            // unameTextBox
            // 
            this.unameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unameTextBox.Location = new System.Drawing.Point(107, 26);
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.ReadOnly = true;
            this.unameTextBox.Size = new System.Drawing.Size(228, 21);
            this.unameTextBox.TabIndex = 1;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(107, 62);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(228, 21);
            this.keyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "注册码";
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(116, 102);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 4;
            this.regBtn.Text = "注册";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(215, 102);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "下次再说吧";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = " 申请注册码QQ:402059985";
            // 
            // RegsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegsterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regster";
            this.Load += new System.EventHandler(this.Regster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unameTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
    }
}