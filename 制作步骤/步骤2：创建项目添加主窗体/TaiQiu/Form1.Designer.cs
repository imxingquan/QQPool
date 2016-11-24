namespace TaiQiu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frmOpacityTrackBar = new System.Windows.Forms.TrackBar();
            this.penWeigthTrackBar = new System.Windows.Forms.TrackBar();
            this.ballSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmOpacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWeigthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frmOpacityTrackBar);
            this.flowLayoutPanel1.Controls.Add(this.penWeigthTrackBar);
            this.flowLayoutPanel1.Controls.Add(this.ballSizeTrackBar);
            this.flowLayoutPanel1.Controls.Add(this.colorBtn);
            this.flowLayoutPanel1.Controls.Add(this.helpBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(616, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // frmOpacityTrackBar
            // 
            this.frmOpacityTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmOpacityTrackBar.Location = new System.Drawing.Point(3, 3);
            this.frmOpacityTrackBar.Maximum = 100;
            this.frmOpacityTrackBar.Minimum = 5;
            this.frmOpacityTrackBar.Name = "frmOpacityTrackBar";
            this.frmOpacityTrackBar.Size = new System.Drawing.Size(197, 45);
            this.frmOpacityTrackBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.frmOpacityTrackBar, "窗体透明度");
            this.frmOpacityTrackBar.Value = 60;
            // 
            // penWeigthTrackBar
            // 
            this.penWeigthTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penWeigthTrackBar.Location = new System.Drawing.Point(206, 3);
            this.penWeigthTrackBar.Maximum = 20;
            this.penWeigthTrackBar.Minimum = 1;
            this.penWeigthTrackBar.Name = "penWeigthTrackBar";
            this.penWeigthTrackBar.Size = new System.Drawing.Size(177, 45);
            this.penWeigthTrackBar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.penWeigthTrackBar, " 画笔宽度");
            this.penWeigthTrackBar.Value = 5;
            // 
            // ballSizeTrackBar
            // 
            this.ballSizeTrackBar.Location = new System.Drawing.Point(389, 3);
            this.ballSizeTrackBar.Name = "ballSizeTrackBar";
            this.ballSizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.ballSizeTrackBar.TabIndex = 2;
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.Red;
            this.colorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.colorBtn.Location = new System.Drawing.Point(499, 3);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(38, 34);
            this.colorBtn.TabIndex = 3;
            this.colorBtn.Text = "色";
            this.colorBtn.UseVisualStyleBackColor = false;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.helpBtn.Location = new System.Drawing.Point(543, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(38, 34);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "帮";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 408);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "敏捷学院mjxy.cn-----桌球瞄准器2011";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmOpacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWeigthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballSizeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar frmOpacityTrackBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TrackBar penWeigthTrackBar;
        private System.Windows.Forms.TrackBar ballSizeTrackBar;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

