namespace gacc.Panels
{
    partial class PanelDemands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelDemands));
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_provider_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.didDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprovideridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.tstrMenu.SuspendLayout();
            this.tstrStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.tstrMenu.Size = new System.Drawing.Size(988, 38);
            this.tstrMenu.TabIndex = 12;
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
            // stsepSeparator1
            // 
            this.stsepSeparator1.Name = "stsepSeparator1";
            this.stsepSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnContent
            // 
            this.tsbtnContent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnContent.Image")));
            this.tsbtnContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnContent.Name = "tsbtnContent";
            this.tsbtnContent.Size = new System.Drawing.Size(96, 35);
            this.tsbtnContent.Text = "Состав запроса";
            this.tsbtnContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnContent.Click += new System.EventHandler(this.tsbtnContent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
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
            // tstxtFilter
            // 
            this.tstxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstxtFilter.Name = "tstxtFilter";
            this.tstxtFilter.Size = new System.Drawing.Size(100, 25);
            this.tstxtFilter.TextChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
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
            this.tstrStatusBar.Location = new System.Drawing.Point(0, 556);
            this.tstrStatusBar.Name = "tstrStatusBar";
            this.tstrStatusBar.Size = new System.Drawing.Size(988, 25);
            this.tstrStatusBar.TabIndex = 13;
            // 
            // tslblFilter
            // 
            this.tslblFilter.Name = "tslblFilter";
            this.tslblFilter.Size = new System.Drawing.Size(62, 22);
            this.tslblFilter.Text = "Фильтр:";
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
            // tslblCountCap
            // 
            this.tslblCountCap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblCountCap.Name = "tslblCountCap";
            this.tslblCountCap.Size = new System.Drawing.Size(137, 22);
            this.tslblCountCap.Text = "Загружено записей:";
            this.tslblCountCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.d_provider_id,
            this.didDataGridViewTextBoxColumn,
            this.ddateDataGridViewTextBoxColumn,
            this.ddescriptionDataGridViewTextBoxColumn,
            this.dprovideridDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.BindingSource;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(3, 39);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(982, 514);
            this.dgvData.TabIndex = 14;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "d_id";
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
            this.d_date.DataPropertyName = "d_date";
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
            this.d_description.DataPropertyName = "d_description";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.d_description.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_description.FillWeight = 60F;
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
            this.p_name.FillWeight = 40F;
            this.p_name.HeaderText = "Предпочитаемый поставщик";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // d_provider_id
            // 
            this.d_provider_id.DataPropertyName = "d_provider_id";
            this.d_provider_id.HeaderText = "d_provider_id";
            this.d_provider_id.Name = "d_provider_id";
            this.d_provider_id.ReadOnly = true;
            this.d_provider_id.Visible = false;
            // 
            // didDataGridViewTextBoxColumn
            // 
            this.didDataGridViewTextBoxColumn.DataPropertyName = "d_id";
            this.didDataGridViewTextBoxColumn.HeaderText = "d_id";
            this.didDataGridViewTextBoxColumn.Name = "didDataGridViewTextBoxColumn";
            this.didDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ddateDataGridViewTextBoxColumn
            // 
            this.ddateDataGridViewTextBoxColumn.DataPropertyName = "d_date";
            this.ddateDataGridViewTextBoxColumn.HeaderText = "d_date";
            this.ddateDataGridViewTextBoxColumn.Name = "ddateDataGridViewTextBoxColumn";
            this.ddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ddescriptionDataGridViewTextBoxColumn
            // 
            this.ddescriptionDataGridViewTextBoxColumn.DataPropertyName = "d_description";
            this.ddescriptionDataGridViewTextBoxColumn.HeaderText = "d_description";
            this.ddescriptionDataGridViewTextBoxColumn.Name = "ddescriptionDataGridViewTextBoxColumn";
            this.ddescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dprovideridDataGridViewTextBoxColumn
            // 
            this.dprovideridDataGridViewTextBoxColumn.DataPropertyName = "d_provider_id";
            this.dprovideridDataGridViewTextBoxColumn.HeaderText = "d_provider_id";
            this.dprovideridDataGridViewTextBoxColumn.Name = "dprovideridDataGridViewTextBoxColumn";
            this.dprovideridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "p_name";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSource
            // 
            this.BindingSource.DataMember = "query_DemandsList";
            this.BindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelDemands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tstrMenu);
            this.Controls.Add(this.tstrStatusBar);
            this.Controls.Add(this.dgvData);
            this.Name = "PanelDemands";
            this.Size = new System.Drawing.Size(988, 581);
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
        private System.Windows.Forms.ToolStripTextBox tstxtFilter;
        private System.Windows.Forms.ToolStrip tstrStatusBar;
        private System.Windows.Forms.ToolStripLabel tslblFilter;
        private System.Windows.Forms.ToolStripLabel tslblCount;
        private System.Windows.Forms.ToolStripLabel tslblCountCap;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnViewDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_provider_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn didDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprovideridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
    }
}
