namespace gacc
{
    partial class WindowCounterpartySummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowCounterpartySummary));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRange = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.tChart = new Steema.TeeChart.TChart();
            this.pie1 = new Steema.TeeChart.Styles.Pie();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnClose);
            this.pnlFilter.Controls.Add(this.lblRange);
            this.pnlFilter.Controls.Add(this.picIcon);
            this.pnlFilter.Controls.Add(this.btnUpdate);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(803, 77);
            this.pnlFilter.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(707, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(84, 18);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(159, 13);
            this.lblRange.TabIndex = 8;
            this.lblRange.Text = "Диапазон просмотра данных:";
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(463, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(87, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(178, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(271, 38);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(178, 20);
            this.dtpTo.TabIndex = 0;
            // 
            // tChart
            // 
            // 
            // 
            // 
            this.tChart.Aspect.Elevation = 315;
            this.tChart.Aspect.ElevationFloat = 315D;
            this.tChart.Aspect.Orthogonal = false;
            this.tChart.Aspect.Perspective = 0;
            this.tChart.Aspect.Rotation = 360;
            this.tChart.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.Bottom.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.Depth.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.DepthTop.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.Left.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Left.Title.Shadow.Visible = false;
            this.tChart.Axes.Left.Visible = false;
            // 
            // 
            // 
            this.tChart.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.Right.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.tChart.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.tChart.Axes.Top.Grid.ZPosition = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Font.Shadow.Visible = false;
            this.tChart.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Font.Shadow.Visible = false;
            this.tChart.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Axes.Top.Title.Shadow.Visible = false;
            this.tChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Footer.Font.Shadow.Visible = false;
            this.tChart.Footer.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Header.Font.Shadow.Visible = false;
            this.tChart.Header.Font.Unit = System.Drawing.GraphicsUnit.World;
            this.tChart.Header.Lines = new string[] {
        ""};
            // 
            // 
            // 
            this.tChart.Header.Shadow.Visible = false;
            this.tChart.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Font.Shadow.Visible = false;
            this.tChart.Legend.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart.Legend.Title.Font.Shadow.Visible = false;
            this.tChart.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart.Legend.Title.Shadow.Visible = false;
            this.tChart.Location = new System.Drawing.Point(0, 77);
            this.tChart.Name = "tChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Panel.Shadow.Visible = false;
            this.tChart.Series.Add(this.pie1);
            this.tChart.Size = new System.Drawing.Size(803, 484);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubFooter.Font.Shadow.Visible = false;
            this.tChart.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.SubHeader.Font.Shadow.Visible = false;
            this.tChart.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World;
            // 
            // 
            // 
            this.tChart.SubHeader.Shadow.Visible = false;
            this.tChart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.tChart.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.tChart.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.tChart.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.tChart.Walls.Right.Shadow.Visible = false;
            this.tChart.Walls.Visible = false;
            // 
            // pie1
            // 
            // 
            // 
            // 
            this.pie1.Brush.Color = System.Drawing.Color.Red;
            this.pie1.Brush.Style = System.Drawing.Drawing2D.HatchStyle.Divot;
            this.pie1.LabelMember = "Labels";
            this.pie1.Labels = ((Steema.TeeChart.Styles.StringList)(resources.GetObject("pie1.Labels")));
            // 
            // 
            // 
            // 
            // 
            // 
            this.pie1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pie1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pie1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pie1.Marks.Callout.Distance = 0;
            this.pie1.Marks.Callout.Draw3D = false;
            this.pie1.Marks.Callout.Length = 8;
            this.pie1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.pie1.Marks.Font.Shadow.Visible = false;
            this.pie1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World;
            this.pie1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Percent;
            // 
            // 
            // 
            this.pie1.Shadow.Height = 20;
            this.pie1.Shadow.Width = 20;
            this.pie1.Title = "pie1";
            // 
            // 
            // 
            this.pie1.XValues.DataMember = "Angle";
            this.pie1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.pie1.YValues.DataMember = "Pie";
            // 
            // WindowCounterpartySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(803, 561);
            this.Controls.Add(this.tChart);
            this.Controls.Add(this.pnlFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WindowCounterpartySummary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Доходы по контрагентам";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private Steema.TeeChart.TChart tChart;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRange;
        private Steema.TeeChart.Styles.Pie pie1;
    }
}