namespace Rubber_Sheet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HomeMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MotorControl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChartViews = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Warning = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.User = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1046);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 1046);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMain,
            this.toolStripSeparator1,
            this.MotorControl,
            this.toolStripSeparator2,
            this.ChartViews,
            this.toolStripSeparator3,
            this.Settings,
            this.toolStripSeparator4,
            this.Warning,
            this.toolStripSeparator5,
            this.User,
            this.toolStripSeparator6});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 150);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(219, 368);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HomeMain
            // 
            this.HomeMain.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.HomeMain.Image = global::Rubber_Sheet.Properties.Resources.Home_48px;
            this.HomeMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HomeMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeMain.Name = "HomeMain";
            this.HomeMain.Size = new System.Drawing.Size(217, 52);
            this.HomeMain.Text = "Main Home";
            this.HomeMain.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // MotorControl
            // 
            this.MotorControl.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MotorControl.Image = global::Rubber_Sheet.Properties.Resources.Robot_48px;
            this.MotorControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MotorControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MotorControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MotorControl.Name = "MotorControl";
            this.MotorControl.Size = new System.Drawing.Size(217, 52);
            this.MotorControl.Text = "Motor Control";
            this.MotorControl.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // ChartViews
            // 
            this.ChartViews.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ChartViews.Image = global::Rubber_Sheet.Properties.Resources.Combo_Chart_48px;
            this.ChartViews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChartViews.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChartViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartViews.Name = "ChartViews";
            this.ChartViews.Size = new System.Drawing.Size(217, 52);
            this.ChartViews.Text = "Chart Views";
            this.ChartViews.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // Settings
            // 
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Settings.Image = global::Rubber_Sheet.Properties.Resources.Settings_48px;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(217, 52);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // Warning
            // 
            this.Warning.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Warning.Image = global::Rubber_Sheet.Properties.Resources.Error_48px;
            this.Warning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Warning.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Warning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(217, 52);
            this.Warning.Text = "Warning";
            this.Warning.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.User.Image = global::Rubber_Sheet.Properties.Resources.Worker_48px;
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.User.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(217, 52);
            this.User.Text = "User";
            this.User.Click += new System.EventHandler(this.SelectView_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(217, 6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Rubber_Sheet.Properties.Resources._36f4bfe9e0a909f750b8;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1701, 83);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Blue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(104, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1503, 54);
            this.label14.TabIndex = 4;
            this.label14.Text = "HỆ THỐNG GIÁM SÁT VÀ ĐIỀU KHIỂN BUỒNG SẤY CAO SU TẤM";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(219, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1701, 963);
            this.panel4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1078);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển và giám sát Tủ sấy Cao su Tấm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HomeMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton MotorControl;
        private System.Windows.Forms.ToolStripButton ChartViews;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.ToolStripButton Warning;
        private System.Windows.Forms.ToolStripButton User;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label14;
    }
}

