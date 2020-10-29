namespace Rubber_Sheet.Views
{
    partial class UserWarning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rectangleShape11 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape11
            // 
            this.rectangleShape11.BorderColor = System.Drawing.SystemColors.Highlight;
            this.rectangleShape11.CornerRadius = 5;
            this.rectangleShape11.Location = new System.Drawing.Point(7, 12);
            this.rectangleShape11.Name = "rectangleShape11";
            this.rectangleShape11.Size = new System.Drawing.Size(1680, 856);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape11});
            this.shapeContainer1.Size = new System.Drawing.Size(1694, 880);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Teal;
            this.label14.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(689, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(276, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "NHẬT KÝ HOẠT ĐỘNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Date,
            this.Status,
            this.Notes});
            this.dataGridView1.Location = new System.Drawing.Point(212, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1302, 761);
            this.dataGridView1.TabIndex = 27;
            // 
            // Time
            // 
            this.Time.FillWeight = 91.06783F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Date
            // 
            this.Date.FillWeight = 82.95779F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Status
            // 
            this.Status.FillWeight = 40.60913F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Notes
            // 
            this.Notes.FillWeight = 185.3652F;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // UserWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UserWarning";
            this.Size = new System.Drawing.Size(1694, 880);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape11;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}
