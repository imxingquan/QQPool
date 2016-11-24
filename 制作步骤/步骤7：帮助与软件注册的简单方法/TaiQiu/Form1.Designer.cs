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
            this.colorBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.regButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(986, 51);
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
            this.frmOpacityTrackBar.Scroll += new System.EventHandler(this.frmOpacityTrackBar_Scroll);
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
            this.penWeigthTrackBar.Scroll += new System.EventHandler(this.penWeigthTrackBar_Scroll);
            // 
            // ballSizeTrackBar
            // 
            this.ballSizeTrackBar.Location = new System.Drawing.Point(389, 3);
            this.ballSizeTrackBar.Maximum = 100;
            this.ballSizeTrackBar.Name = "ballSizeTrackBar";
            this.ballSizeTrackBar.Size = new System.Drawing.Size(253, 45);
            this.ballSizeTrackBar.TabIndex = 2;
            this.ballSizeTrackBar.Scroll += new System.EventHandler(this.ballSizeTrackBar_Scroll);
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.Red;
            this.colorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.colorBtn.Location = new System.Drawing.Point(648, 3);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(38, 34);
            this.colorBtn.TabIndex = 3;
            this.colorBtn.Text = "色";
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.helpBtn.Location = new System.Drawing.Point(692, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(38, 34);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "帮";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(736, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "未注册,剩余使用时间";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10F);
            this.label3.Location = new System.Drawing.Point(882, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "tt";
            this.label3.Visible = false;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.regButton.Location = new System.Drawing.Point(909, 3);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(39, 23);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "注册";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Visible = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 408);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "敏捷学院mjxy.cn-----桌球瞄准器2011";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Timer timer1;
    }
}

