namespace gacc
{
    partial class DialogGoodsSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogGoodsSelection));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdescription1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdescription2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmanufactureridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ggroupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.tstrMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tstrMenu
            // 
            this.tstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnCancel});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(592, 38);
            this.tstrMenu.TabIndex = 2;
            this.tstrMenu.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(63, 35);
            this.tsbtnAdd.Text = "Добавить";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(53, 35);
            this.tsbtnCancel.Text = "Отмена";
            this.tsbtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
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
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gidDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.gmodelDataGridViewTextBoxColumn,
            this.gdescription1DataGridViewTextBoxColumn,
            this.gdescription2DataGridViewTextBoxColumn,
            this.gpriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.gmanufactureridDataGridViewTextBoxColumn,
            this.ggroupidDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.BindingSource;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(0, 39);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(592, 336);
            this.dgvData.TabIndex = 3;
            // 
            // gidDataGridViewTextBoxColumn
            // 
            this.gidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gidDataGridViewTextBoxColumn.DataPropertyName = "g_id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Format = "0000";
            this.gidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.gidDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.gidDataGridViewTextBoxColumn.Name = "gidDataGridViewTextBoxColumn";
            this.gidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gidDataGridViewTextBoxColumn.Width = 58;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "g_name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gnameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.gnameDataGridViewTextBoxColumn.HeaderText = "Номенклатурная группа";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "m_name";
            this.mnameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.mnameDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            this.mnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gmodelDataGridViewTextBoxColumn
            // 
            this.gmodelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gmodelDataGridViewTextBoxColumn.DataPropertyName = "g_model";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gmodelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.gmodelDataGridViewTextBoxColumn.FillWeight = 15F;
            this.gmodelDataGridViewTextBoxColumn.HeaderText = "Спецификация (модель)";
            this.gmodelDataGridViewTextBoxColumn.Name = "gmodelDataGridViewTextBoxColumn";
            this.gmodelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gdescription1DataGridViewTextBoxColumn
            // 
            this.gdescription1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gdescription1DataGridViewTextBoxColumn.DataPropertyName = "g_description1";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdescription1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gdescription1DataGridViewTextBoxColumn.FillWeight = 27F;
            this.gdescription1DataGridViewTextBoxColumn.HeaderText = "Описание 1";
            this.gdescription1DataGridViewTextBoxColumn.Name = "gdescription1DataGridViewTextBoxColumn";
            this.gdescription1DataGridViewTextBoxColumn.ReadOnly = true;
            this.gdescription1DataGridViewTextBoxColumn.Visible = false;
            // 
            // gdescription2DataGridViewTextBoxColumn
            // 
            this.gdescription2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gdescription2DataGridViewTextBoxColumn.DataPropertyName = "g_description2";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdescription2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdescription2DataGridViewTextBoxColumn.FillWeight = 28F;
            this.gdescription2DataGridViewTextBoxColumn.HeaderText = "Описание 2";
            this.gdescription2DataGridViewTextBoxColumn.Name = "gdescription2DataGridViewTextBoxColumn";
            this.gdescription2DataGridViewTextBoxColumn.ReadOnly = true;
            this.gdescription2DataGridViewTextBoxColumn.Visible = false;
            // 
            // gpriceDataGridViewTextBoxColumn
            // 
            this.gpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gpriceDataGridViewTextBoxColumn.DataPropertyName = "g_price";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.gpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.gpriceDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            this.gpriceDataGridViewTextBoxColumn.Name = "gpriceDataGridViewTextBoxColumn";
            this.gpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.gpriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gpriceDataGridViewTextBoxColumn.Visible = false;
            this.gpriceDataGridViewTextBoxColumn.Width = 110;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantityDataGridViewTextBoxColumn.Visible = false;
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // gmanufactureridDataGridViewTextBoxColumn
            // 
            this.gmanufactureridDataGridViewTextBoxColumn.DataPropertyName = "g_manufacturer_id";
            this.gmanufactureridDataGridViewTextBoxColumn.HeaderText = "g_manufacturer_id";
            this.gmanufactureridDataGridViewTextBoxColumn.Name = "gmanufactureridDataGridViewTextBoxColumn";
            this.gmanufactureridDataGridViewTextBoxColumn.ReadOnly = true;
            this.gmanufactureridDataGridViewTextBoxColumn.Visible = false;
            // 
            // ggroupidDataGridViewTextBoxColumn
            // 
            this.ggroupidDataGridViewTextBoxColumn.DataPropertyName = "g_group_id";
            this.ggroupidDataGridViewTextBoxColumn.HeaderText = "g_group_id";
            this.ggroupidDataGridViewTextBoxColumn.Name = "ggroupidDataGridViewTextBoxColumn";
            this.ggroupidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ggroupidDataGridViewTextBoxColumn.Visible = false;
            // 
            // BindingSource
            // 
            this.BindingSource.DataMember = "query_GoodsAll";
            this.BindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DialogGoodsSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 371);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tstrMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "DialogGoodsSelection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор товаров";
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Windows.Forms.BindingSource BindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdescription1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdescription2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmanufactureridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ggroupidDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvData;
    }
}