namespace gacc.Panels
{
    partial class PanelSupplies
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSupplies));
            this.dbDataSet = new gacc.dbDataSet();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_provider_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tslblCountCap = new System.Windows.Forms.ToolStripLabel();
            this.tslblCount = new System.Windows.Forms.ToolStripLabel();
            this.tslblFilter = new System.Windows.Forms.ToolStripLabel();
            this.tstrStatusBar = new System.Windows.Forms.ToolStrip();
            this.tstxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnViewDocument = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnContent = new System.Windows.Forms.ToolStripButton();
            this.stsepSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tstrStatusBar.SuspendLayout();
            this.tstrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BindingSource
            // 
            this.BindingSource.DataMember = "query_SupplyList";
            this.BindingSource.DataSource = this.dbDataSet;
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
            this.Column1,
            this.d_date,
            this.d_description,
            this.p_name,
            this.s_address,
            this.d_provider_id,
            this.pnameDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.BindingSource;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(3, 39);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(980, 512);
            this.dgvData.TabIndex = 17;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "s_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Format = "0000";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // d_date
            // 
            this.d_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.d_date.DataPropertyName = "s_date";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.d_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_date.HeaderText = "Дата";
            this.d_date.Name = "d_date";
            this.d_date.ReadOnly = true;
            this.d_date.Width = 110;
            // 
            // d_description
            // 
            this.d_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.d_description.DataPropertyName = "s_description";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d_description.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_description.FillWeight = 40F;
            this.d_description.HeaderText = "Коментарий";
            this.d_description.Name = "d_description";
            this.d_description.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_name.DataPropertyName = "p_name";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.p_name.DefaultCellStyle = dataGridViewCellStyle4;
            this.p_name.FillWeight = 30F;
            this.p_name.HeaderText = "Поставщик";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // s_address
            // 
            this.s_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_address.DataPropertyName = "s_address";
            this.s_address.FillWeight = 30F;
            this.s_address.HeaderText = "Магазин";
            this.s_address.Name = "s_address";
            this.s_address.ReadOnly = true;
            // 
            // d_provider_id
            // 
            this.d_provider_id.DataPropertyName = "s_provider_id";
            this.d_provider_id.HeaderText = "s_provider_id";
            this.d_provider_id.Name = "d_provider_id";
            this.d_provider_id.ReadOnly = true;
            this.d_provider_id.Visible = false;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "s_shop_id";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "s_shop_id";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // tslblCountCap
            // 
            this.tslblCountCap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblCountCap.Name = "tslblCountCap";
            this.tslblCountCap.Size = new System.Drawing.Size(137, 22);
            this.tslblCountCap.Text = "Загружено записей:";
            this.tslblCountCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblCount
            // 
            this.tslblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tslblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tslblCount.Name = "tslblCount";
            this.tslblCount.Size = new System.Drawing.Size(12, 22);
            this.tslblCount.Text = "-";
            this.tslblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblFilter
            // 
            this.tslblFilter.Name = "tslblFilter";
            this.tslblFilter.Size = new System.Drawing.Size(62, 22);
            this.tslblFilter.Text = "Фильтр:";
            // 
            // tstrStatusBar
            // 
            this.tstrStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstrStatusBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tstrStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFilter,
            this.tstxtFilter,
            this.tslblCount,
            this.tslblCountCap});
            this.tstrStatusBar.Location = new System.Drawing.Point(0, 554);
            this.tstrStatusBar.Name = "tstrStatusBar";
            this.tstrStatusBar.Size = new System.Drawing.Size(986, 25);
            this.tstrStatusBar.TabIndex = 16;
            // 
            // tstxtFilter
            // 
            this.tstxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstxtFilter.Name = "tstxtFilter";
            this.tstxtFilter.Size = new System.Drawing.Size(100, 25);
            this.tstxtFilter.TextChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
            // 
            // tsbtnViewDocument
            // 
            this.tsbtnViewDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnViewDocument.Image")));
            this.tsbtnViewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewDocument.Name = "tsbtnViewDocument";
            this.tsbtnViewDocument.Size = new System.Drawing.Size(65, 35);
            this.tsbtnViewDocument.Text = "Документ";
            this.tsbtnViewDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnViewDocument.Click += new System.EventHandler(this.tsbtnViewDocument_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnContent
            // 
            this.tsbtnContent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContent.Image")));
            this.tsbtnContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContent.Name = "tsbtnContent";
            this.tsbtnContent.Size = new System.Drawing.Size(102, 35);
            this.tsbtnContent.Text = "Состав поставки";
            this.tsbtnContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnContent.Click += new System.EventHandler(this.tsbtnContent_Click);
            // 
            // stsepSeparator1
            // 
            this.stsepSeparator1.Name = "stsepSeparator1";
            this.stsepSeparator1.Size = new System.Drawing.Size(6, 38);
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
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(100, 35);
            this.tsbtnEdit.Text = "Редактировать...";
            this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
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
            // tstrMenu
            // 
            this.tstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.stsepSeparator1,
            this.tsbtnContent,
            this.toolStripSeparator1,
            this.tsbtnViewDocument});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(986, 38);
            this.tstrMenu.TabIndex = 15;
            this.tstrMenu.Text = "toolStrip1";
            // 
            // PanelSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tstrStatusBar);
            this.Controls.Add(this.tstrMenu);
            this.Name = "PanelSupplies";
            this.Size = new System.Drawing.Size(986, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tstrStatusBar.ResumeLayout(false);
            this.tstrStatusBar.PerformLayout();
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_provider_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel tslblCountCap;
        private System.Windows.Forms.ToolStripLabel tslblCount;
        private System.Windows.Forms.ToolStripLabel tslblFilter;
        private System.Windows.Forms.ToolStrip tstrStatusBar;
        private System.Windows.Forms.ToolStripTextBox tstxtFilter;
        private System.Windows.Forms.ToolStripButton tsbtnViewDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnContent;
        private System.Windows.Forms.ToolStripSeparator stsepSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStrip tstrMenu;
    }
}
