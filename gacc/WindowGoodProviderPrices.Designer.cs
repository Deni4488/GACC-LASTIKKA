namespace gacc
{
    partial class WindowGoodProviderPrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowGoodProviderPrices));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblDescr1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescr2 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.tChart = new Steema.TeeChart.TChart();
            this.bar1 = new Steema.TeeChart.Styles.Bar();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblDescr1);
            this.pnlFilter.Controls.Add(this.btnClose);
            this.pnlFilter.Controls.Add(this.lblDescr2);
            this.pnlFilter.Controls.Add(this.picIcon);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(784, 77);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblDescr1
            // 
            this.lblDescr1.AutoSize = true;
            this.lblDescr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescr1.Location = new System.Drawing.Point(68, 15);
            this.lblDescr1.Name = "lblDescr1";
            this.lblDescr1.Size = new System.Drawing.Size(200, 13);
            this.lblDescr1.TabIndex = 10;
            this.lblDescr1.Text = "Группа: Производитель, модель";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(684, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDescr2
            // 
            this.lblDescr2.AutoSize = true;
            this.lblDescr2.Location = new System.Drawing.Point(68, 34);
            this.lblDescr2.Name = "lblDescr2";
            this.lblDescr2.Size = new System.Drawing.Size(393, 13);
            this.lblDescr2.TabIndex = 8;
            this.lblDescr2.Text = "На диаграмме показаны цены различных поствщиков на выбранный товар";
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
            // tChart
            // 
            this.tChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tChart.Aspect.ElevationFloat = 345D;
            this.tChart.Aspect.RotationFloat = 345D;
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
            this.tChart.Axes.Bottom.Visible = false;
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
        "TeeChart"};
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
            this.tChart.Legend.Visible = false;
            this.tChart.Location = new System.Drawing.Point(0, 83);
            this.tChart.Name = "tChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart.Panel.Shadow.Visible = false;
            this.tChart.Series.Add(this.bar1);
            this.tChart.Size = new System.Drawing.Size(784, 475);
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
            this.tChart.TabIndex = 3;
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
            // 
            // bar1
            // 
            // 
            // 
            // 
            this.bar1.Brush.Color = System.Drawing.Color.Red;
            this.bar1.ColorEach = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bar1.Marks.Callout.Distance = 0;
            this.bar1.Marks.Callout.Draw3D = false;
            this.bar1.Marks.Callout.Length = 20;
            this.bar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bar1.Marks.Font.Shadow.Visible = false;
            this.bar1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World;
            this.bar1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.LabelValue;
            // 
            // 
            // 
            this.bar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.bar1.Title = "bar1";
            // 
            // 
            // 
            this.bar1.XValues.DataMember = "X";
            this.bar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.bar1.YValues.DataMember = "Bar";
            // 
            // WindowGoodProviderPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tChart);
            this.Controls.Add(this.pnlFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WindowGoodProviderPrices";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Номенклатура цен поставщиков";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDescr2;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblDescr1;
        private Steema.TeeChart.Styles.Bar bar1;
        private Steema.TeeChart.TChart tChart;
    }
}