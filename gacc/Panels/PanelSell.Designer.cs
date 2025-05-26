namespace gacc.Panels
{
    partial class PanelSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSell));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.stsepSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnContent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnViewDocument = new System.Windows.Forms.ToolStripButton();
            this.tstxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tstrStatusBar = new System.Windows.Forms.ToolStrip();
            this.tslblFilter = new System.Windows.Forms.ToolStripLabel();
            this.tslblCount = new System.Windows.Forms.ToolStripLabel();
            this.tslblCountCap = new System.Windows.Forms.ToolStripLabel();
            this.tslblDateFilterCap = new System.Windows.Forms.ToolStripLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_provider_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.query_SellListTableAdapter = new gacc.dbDataSetTableAdapters.query_SellListTableAdapter();
            this.tstrMenu.SuspendLayout();
            this.tstrStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tstrMenu
            // 
            this.tstrMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.tstrMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tstrMenu.Size = new System.Drawing.Size(1480, 58);
            this.tstrMenu.TabIndex = 18;
            this.tstrMenu.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(106, 53);
            this.tsbtnAdd.Text = "Добавить...";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(149, 53);
            this.tsbtnEdit.Text = "Редактировать...";
            this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(80, 53);
            this.tsbtnDelete.Text = "Удалить";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // stsepSeparator1
            // 
            this.stsepSeparator1.Name = "stsepSeparator1";
            this.stsepSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // tsbtnContent
            // 
            this.tsbtnContent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContent.Image")));
            this.tsbtnContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContent.Name = "tsbtnContent";
            this.tsbtnContent.Size = new System.Drawing.Size(151, 53);
            this.tsbtnContent.Text = "Состав продажи";
            this.tsbtnContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnContent.Click += new System.EventHandler(this.tsbtnContent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // tsbtnViewDocument
            // 
            this.tsbtnViewDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnViewDocument.Image")));
            this.tsbtnViewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewDocument.Name = "tsbtnViewDocument";
            this.tsbtnViewDocument.Size = new System.Drawing.Size(96, 53);
            this.tsbtnViewDocument.Text = "Документ";
            this.tsbtnViewDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnViewDocument.Click += new System.EventHandler(this.tsbtnViewDocument_Click);
            // 
            // tstxtFilter
            // 
            this.tstxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstxtFilter.Name = "tstxtFilter";
            this.tstxtFilter.Size = new System.Drawing.Size(148, 38);
            this.tstxtFilter.TextChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
            // 
            // tstrStatusBar
            // 
            this.tstrStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstrStatusBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tstrStatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tstrStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFilter,
            this.tstxtFilter,
            this.tslblCount,
            this.tslblCountCap,
            this.tslblDateFilterCap});
            this.tstrStatusBar.Location = new System.Drawing.Point(0, 868);
            this.tstrStatusBar.Name = "tstrStatusBar";
            this.tstrStatusBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tstrStatusBar.Size = new System.Drawing.Size(1480, 38);
            this.tstrStatusBar.TabIndex = 19;
            // 
            // tslblFilter
            // 
            this.tslblFilter.Name = "tslblFilter";
            this.tslblFilter.Size = new System.Drawing.Size(84, 33);
            this.tslblFilter.Text = "Фильтр:";
            // 
            // tslblCount
            // 
            this.tslblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tslblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tslblCount.Name = "tslblCount";
            this.tslblCount.Size = new System.Drawing.Size(17, 33);
            this.tslblCount.Text = "-";
            this.tslblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblCountCap
            // 
            this.tslblCountCap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblCountCap.Name = "tslblCountCap";
            this.tslblCountCap.Size = new System.Drawing.Size(195, 33);
            this.tslblCountCap.Text = "Загружено записей:";
            this.tslblCountCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslblDateFilterCap
            // 
            this.tslblDateFilterCap.Name = "tslblDateFilterCap";
            this.tslblDateFilterCap.Size = new System.Drawing.Size(136, 33);
            this.tslblDateFilterCap.Text = "Диапазон дат";
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
            this.dgvData.Location = new System.Drawing.Point(4, 60);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1472, 803);
            this.dgvData.TabIndex = 20;
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
            this.Column1.MinimumWidth = 8;
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
            this.d_date.MinimumWidth = 8;
            this.d_date.Name = "d_date";
            this.d_date.ReadOnly = true;
            this.d_date.Width = 110;
            // 
            // d_description
            // 
            this.d_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.d_description.DataPropertyName = "s_username";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d_description.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_description.FillWeight = 40F;
            this.d_description.HeaderText = "Оформил продажу";
            this.d_description.MinimumWidth = 8;
            this.d_description.Name = "d_description";
            this.d_description.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_name.DataPropertyName = "c_name";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.p_name.DefaultCellStyle = dataGridViewCellStyle4;
            this.p_name.FillWeight = 30F;
            this.p_name.HeaderText = "Покупатель";
            this.p_name.MinimumWidth = 8;
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // s_address
            // 
            this.s_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_address.DataPropertyName = "s_address";
            this.s_address.FillWeight = 30F;
            this.s_address.HeaderText = "Магазин";
            this.s_address.MinimumWidth = 8;
            this.s_address.Name = "s_address";
            this.s_address.ReadOnly = true;
            // 
            // d_provider_id
            // 
            this.d_provider_id.DataPropertyName = "s_counterparty_id";
            this.d_provider_id.HeaderText = "s_counterparty_id";
            this.d_provider_id.MinimumWidth = 8;
            this.d_provider_id.Name = "d_provider_id";
            this.d_provider_id.ReadOnly = true;
            this.d_provider_id.Visible = false;
            this.d_provider_id.Width = 150;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "s_shop_id";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "s_shop_id";
            this.pnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Visible = false;
            this.pnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // BindingSource
            // 
            this.BindingSource.DataMember = "query_SellList";
            this.BindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTo.Location = new System.Drawing.Point(698, 871);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(223, 26);
            this.dtpTo.TabIndex = 21;
            this.dtpTo.ValueChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFrom.Location = new System.Drawing.Point(464, 871);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(223, 26);
            this.dtpFrom.TabIndex = 22;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
            // 
            // query_SellListTableAdapter
            // 
            this.query_SellListTableAdapter.ClearBeforeFill = true;
            // 
            // PanelSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.tstrMenu);
            this.Controls.Add(this.tstrStatusBar);
            this.Controls.Add(this.dgvData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PanelSell";
            this.Size = new System.Drawing.Size(1480, 906);
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            this.tstrStatusBar.ResumeLayout(false);
            this.tstrStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator stsepSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnViewDocument;
        private System.Windows.Forms.ToolStripTextBox tstxtFilter;
        private System.Windows.Forms.ToolStrip tstrStatusBar;
        private System.Windows.Forms.ToolStripLabel tslblFilter;
        private System.Windows.Forms.ToolStripLabel tslblCount;
        private System.Windows.Forms.ToolStripLabel tslblCountCap;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource BindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.ToolStripLabel tslblDateFilterCap;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_provider_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private dbDataSetTableAdapters.query_SellListTableAdapter query_SellListTableAdapter;
    }
}
