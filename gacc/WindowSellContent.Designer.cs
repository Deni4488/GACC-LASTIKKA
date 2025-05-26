namespace gacc
{
    partial class WindowSellContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowSellContent));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.xclID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xclSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.txtF = new System.Windows.Forms.TextBox();
            this.lblPositions = new System.Windows.Forms.Label();
            this.lblPositionsCap = new System.Windows.Forms.Label();
            this.grpSeparator = new System.Windows.Forms.GroupBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSummaryCap = new System.Windows.Forms.Label();
            this.lblGoodsCount = new System.Windows.Forms.Label();
            this.lblGoodsCountCap = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountCap = new System.Windows.Forms.Label();
            this.lblDiscountSum = new System.Windows.Forms.Label();
            this.lblDiscountSumCap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tstrMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xclID,
            this.xclManufacturer,
            this.xclGroup,
            this.xclModel,
            this.xclCount,
            this.xclPrice,
            this.xclSumm});
            this.dgvData.Location = new System.Drawing.Point(0, 39);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(792, 360);
            this.dgvData.TabIndex = 14;
            this.dgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
            // 
            // xclID
            // 
            this.xclID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Format = "0000";
            this.xclID.DefaultCellStyle = dataGridViewCellStyle1;
            this.xclID.HeaderText = "Артикул";
            this.xclID.Name = "xclID";
            this.xclID.ReadOnly = true;
            this.xclID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xclID.Width = 55;
            // 
            // xclManufacturer
            // 
            this.xclManufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xclManufacturer.DefaultCellStyle = dataGridViewCellStyle2;
            this.xclManufacturer.FillWeight = 30F;
            this.xclManufacturer.HeaderText = "Производитель";
            this.xclManufacturer.Name = "xclManufacturer";
            this.xclManufacturer.ReadOnly = true;
            // 
            // xclGroup
            // 
            this.xclGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xclGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.xclGroup.FillWeight = 35F;
            this.xclGroup.HeaderText = "Товарная группа";
            this.xclGroup.Name = "xclGroup";
            this.xclGroup.ReadOnly = true;
            // 
            // xclModel
            // 
            this.xclModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xclModel.DefaultCellStyle = dataGridViewCellStyle4;
            this.xclModel.FillWeight = 35F;
            this.xclModel.HeaderText = "Модель";
            this.xclModel.Name = "xclModel";
            this.xclModel.ReadOnly = true;
            // 
            // xclCount
            // 
            this.xclCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.NullValue = null;
            this.xclCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.xclCount.HeaderText = "Кол-во";
            this.xclCount.Name = "xclCount";
            this.xclCount.Width = 50;
            // 
            // xclPrice
            // 
            this.xclPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.xclPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.xclPrice.HeaderText = "Цена";
            this.xclPrice.Name = "xclPrice";
            this.xclPrice.ReadOnly = true;
            this.xclPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // xclSumm
            // 
            this.xclSumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.xclSumm.DefaultCellStyle = dataGridViewCellStyle7;
            this.xclSumm.HeaderText = "Сумма";
            this.xclSumm.Name = "xclSumm";
            this.xclSumm.ReadOnly = true;
            this.xclSumm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xclSumm.Width = 120;
            // 
            // tstrMenu
            // 
            this.tstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tsbtnSave,
            this.toolStripSeparator2,
            this.tsbtnClose});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(792, 38);
            this.tstrMenu.TabIndex = 13;
            this.tstrMenu.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(72, 35);
            this.tsbtnAdd.Text = "Добавить...";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(55, 35);
            this.tsbtnDelete.Text = "Удалить";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(70, 35);
            this.tsbtnSave.Text = "Сохранить";
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(57, 35);
            this.tsbtnClose.Text = "Закрыть";
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(563, 53);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(40, 20);
            this.txtF.TabIndex = 15;
            // 
            // lblPositions
            // 
            this.lblPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPositions.AutoSize = true;
            this.lblPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPositions.ForeColor = System.Drawing.Color.Blue;
            this.lblPositions.Location = new System.Drawing.Point(188, 421);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(14, 13);
            this.lblPositions.TabIndex = 83;
            this.lblPositions.Text = "0";
            // 
            // lblPositionsCap
            // 
            this.lblPositionsCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPositionsCap.AutoSize = true;
            this.lblPositionsCap.Location = new System.Drawing.Point(56, 421);
            this.lblPositionsCap.Name = "lblPositionsCap";
            this.lblPositionsCap.Size = new System.Drawing.Size(85, 13);
            this.lblPositionsCap.TabIndex = 81;
            this.lblPositionsCap.Text = "Всего позиций:";
            // 
            // grpSeparator
            // 
            this.grpSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSeparator.Location = new System.Drawing.Point(0, 405);
            this.grpSeparator.Name = "grpSeparator";
            this.grpSeparator.Size = new System.Drawing.Size(792, 8);
            this.grpSeparator.TabIndex = 82;
            this.grpSeparator.TabStop = false;
            // 
            // picIcon
            // 
            this.picIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(0, 419);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 80;
            this.picIcon.TabStop = false;
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSummary.Location = new System.Drawing.Point(188, 456);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(29, 13);
            this.lblSummary.TabIndex = 85;
            this.lblSummary.Text = "0 р.";
            // 
            // lblSummaryCap
            // 
            this.lblSummaryCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSummaryCap.AutoSize = true;
            this.lblSummaryCap.Location = new System.Drawing.Point(56, 456);
            this.lblSummaryCap.Name = "lblSummaryCap";
            this.lblSummaryCap.Size = new System.Drawing.Size(128, 13);
            this.lblSummaryCap.TabIndex = 84;
            this.lblSummaryCap.Text = "Общая сумма продажи:";
            // 
            // lblGoodsCount
            // 
            this.lblGoodsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGoodsCount.AutoSize = true;
            this.lblGoodsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoodsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblGoodsCount.Location = new System.Drawing.Point(188, 438);
            this.lblGoodsCount.Name = "lblGoodsCount";
            this.lblGoodsCount.Size = new System.Drawing.Size(14, 13);
            this.lblGoodsCount.TabIndex = 87;
            this.lblGoodsCount.Text = "0";
            // 
            // lblGoodsCountCap
            // 
            this.lblGoodsCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGoodsCountCap.AutoSize = true;
            this.lblGoodsCountCap.Location = new System.Drawing.Point(56, 438);
            this.lblGoodsCountCap.Name = "lblGoodsCountCap";
            this.lblGoodsCountCap.Size = new System.Drawing.Size(84, 13);
            this.lblGoodsCountCap.TabIndex = 86;
            this.lblGoodsCountCap.Text = "Всего товаров:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblDiscount.Location = new System.Drawing.Point(496, 438);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(14, 13);
            this.lblDiscount.TabIndex = 91;
            this.lblDiscount.Text = "0";
            // 
            // lblDiscountCap
            // 
            this.lblDiscountCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscountCap.AutoSize = true;
            this.lblDiscountCap.Location = new System.Drawing.Point(317, 438);
            this.lblDiscountCap.Name = "lblDiscountCap";
            this.lblDiscountCap.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountCap.TabIndex = 90;
            this.lblDiscountCap.Text = "Скидка клиента:";
            // 
            // lblDiscountSum
            // 
            this.lblDiscountSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscountSum.AutoSize = true;
            this.lblDiscountSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscountSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDiscountSum.Location = new System.Drawing.Point(496, 456);
            this.lblDiscountSum.Name = "lblDiscountSum";
            this.lblDiscountSum.Size = new System.Drawing.Size(29, 13);
            this.lblDiscountSum.TabIndex = 89;
            this.lblDiscountSum.Text = "0 р.";
            // 
            // lblDiscountSumCap
            // 
            this.lblDiscountSumCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscountSumCap.AutoSize = true;
            this.lblDiscountSumCap.Location = new System.Drawing.Point(317, 456);
            this.lblDiscountSumCap.Name = "lblDiscountSumCap";
            this.lblDiscountSumCap.Size = new System.Drawing.Size(167, 13);
            this.lblDiscountSumCap.TabIndex = 88;
            this.lblDiscountSumCap.Text = "Общая сумма с учетом скидки:";
            // 
            // WindowSellContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountCap);
            this.Controls.Add(this.lblDiscountSum);
            this.Controls.Add(this.lblDiscountSumCap);
            this.Controls.Add(this.lblGoodsCount);
            this.Controls.Add(this.lblGoodsCountCap);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblSummaryCap);
            this.Controls.Add(this.lblPositions);
            this.Controls.Add(this.lblPositionsCap);
            this.Controls.Add(this.grpSeparator);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tstrMenu);
            this.Controls.Add(this.txtF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "WindowSellContent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные продажи";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label lblPositions;
        private System.Windows.Forms.Label lblPositionsCap;
        private System.Windows.Forms.GroupBox grpSeparator;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSummaryCap;
        private System.Windows.Forms.Label lblGoodsCount;
        private System.Windows.Forms.Label lblGoodsCountCap;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountCap;
        private System.Windows.Forms.Label lblDiscountSum;
        private System.Windows.Forms.Label lblDiscountSumCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn xclSumm;
    }
}