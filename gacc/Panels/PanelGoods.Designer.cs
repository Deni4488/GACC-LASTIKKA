namespace gacc.Panels
{
    partial class PanelGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelGoods));
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
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnProviderPrices = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCounts = new System.Windows.Forms.ToolStripButton();
            this.tstrStatusBar = new System.Windows.Forms.ToolStrip();
            this.tslblCount = new System.Windows.Forms.ToolStripLabel();
            this.tslblCountCap = new System.Windows.Forms.ToolStripLabel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkExists = new System.Windows.Forms.CheckBox();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.chkManufacturer = new System.Windows.Forms.CheckBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.bindingSourceManufacturers = new System.Windows.Forms.BindingSource(this.components);
            this.txtModel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.tstrMenu.SuspendLayout();
            this.tstrStatusBar.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManufacturers)).BeginInit();
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
            this.dgvData.Location = new System.Drawing.Point(3, 39);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(981, 419);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
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
            this.gidDataGridViewTextBoxColumn.Width = 60;
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
            // tstrMenu
            // 
            this.tstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tsbtnProviderPrices,
            this.tsbtnCounts});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(987, 38);
            this.tstrMenu.TabIndex = 0;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnProviderPrices
            // 
            this.tsbtnProviderPrices.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProviderPrices.Image")));
            this.tsbtnProviderPrices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProviderPrices.Name = "tsbtnProviderPrices";
            this.tsbtnProviderPrices.Size = new System.Drawing.Size(128, 35);
            this.tsbtnProviderPrices.Text = "Цены поставщиков...";
            this.tsbtnProviderPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnProviderPrices.Click += new System.EventHandler(this.tsbtnProviderPrices_Click);
            // 
            // tsbtnCounts
            // 
            this.tsbtnCounts.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCounts.Image")));
            this.tsbtnCounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCounts.Name = "tsbtnCounts";
            this.tsbtnCounts.Size = new System.Drawing.Size(64, 35);
            this.tsbtnCounts.Text = "Остатки...";
            this.tsbtnCounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCounts.Click += new System.EventHandler(this.tsbtnCounts_Click);
            // 
            // tstrStatusBar
            // 
            this.tstrStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstrStatusBar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tstrStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblCount,
            this.tslblCountCap});
            this.tstrStatusBar.Location = new System.Drawing.Point(0, 564);
            this.tstrStatusBar.Name = "tstrStatusBar";
            this.tstrStatusBar.Size = new System.Drawing.Size(987, 25);
            this.tstrStatusBar.TabIndex = 3;
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
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.btnResetFilter);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.chkExists);
            this.grpSearch.Controls.Add(this.chkDescription);
            this.grpSearch.Controls.Add(this.chkModel);
            this.grpSearch.Controls.Add(this.chkManufacturer);
            this.grpSearch.Controls.Add(this.chkGroup);
            this.grpSearch.Controls.Add(this.txtDescription1);
            this.grpSearch.Controls.Add(this.cmbGroup);
            this.grpSearch.Controls.Add(this.cmbManufacturer);
            this.grpSearch.Controls.Add(this.txtModel);
            this.grpSearch.Location = new System.Drawing.Point(3, 464);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(981, 97);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Поиск";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.Location = new System.Drawing.Point(888, 68);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 10;
            this.btnResetFilter.Text = "Сброс";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(809, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkExists
            // 
            this.chkExists.AutoSize = true;
            this.chkExists.Location = new System.Drawing.Point(6, 67);
            this.chkExists.Name = "chkExists";
            this.chkExists.Size = new System.Drawing.Size(331, 17);
            this.chkExists.TabIndex = 4;
            this.chkExists.Text = "Не показывать товары, которых нет в наличии в магазинах";
            this.chkExists.UseVisualStyleBackColor = true;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Location = new System.Drawing.Point(421, 41);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(143, 17);
            this.chkDescription.TabIndex = 7;
            this.chkDescription.Text = "Информация описания";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Location = new System.Drawing.Point(421, 19);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(294, 17);
            this.chkModel.TabIndex = 5;
            this.chkModel.Text = "Наименование модели (обозначение спецификации)";
            this.chkModel.UseVisualStyleBackColor = true;
            // 
            // chkManufacturer
            // 
            this.chkManufacturer.AutoSize = true;
            this.chkManufacturer.Location = new System.Drawing.Point(6, 43);
            this.chkManufacturer.Name = "chkManufacturer";
            this.chkManufacturer.Size = new System.Drawing.Size(105, 17);
            this.chkManufacturer.TabIndex = 2;
            this.chkManufacturer.Text = "Производитель";
            this.chkManufacturer.UseVisualStyleBackColor = true;
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Location = new System.Drawing.Point(6, 19);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(149, 17);
            this.chkGroup.TabIndex = 0;
            this.chkGroup.Text = "Номенклатурная группа";
            this.chkGroup.UseVisualStyleBackColor = true;
            // 
            // txtDescription1
            // 
            this.txtDescription1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription1.Location = new System.Drawing.Point(722, 44);
            this.txtDescription1.MaxLength = 255;
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.Size = new System.Drawing.Size(241, 20);
            this.txtDescription1.TabIndex = 8;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.bindingSourceGroups;
            this.cmbGroup.DisplayMember = "g_name";
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(161, 17);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(241, 21);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.ValueMember = "g_id";
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataMember = "groups";
            this.bindingSourceGroups.DataSource = this.dbDataSet;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataSource = this.bindingSourceManufacturers;
            this.cmbManufacturer.DisplayMember = "m_name";
            this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(161, 41);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(241, 21);
            this.cmbManufacturer.TabIndex = 3;
            this.cmbManufacturer.ValueMember = "m_id";
            // 
            // bindingSourceManufacturers
            // 
            this.bindingSourceManufacturers.DataMember = "manufacturers";
            this.bindingSourceManufacturers.DataSource = this.dbDataSet;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Location = new System.Drawing.Point(722, 18);
            this.txtModel.MaxLength = 255;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(241, 20);
            this.txtModel.TabIndex = 6;
            // 
            // PanelGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tstrMenu);
            this.Controls.Add(this.tstrStatusBar);
            this.Name = "PanelGoods";
            this.Size = new System.Drawing.Size(987, 589);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            this.tstrStatusBar.ResumeLayout(false);
            this.tstrStatusBar.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnProviderPrices;
        private System.Windows.Forms.ToolStripButton tsbtnCounts;
        private System.Windows.Forms.ToolStrip tstrStatusBar;
        private System.Windows.Forms.ToolStripLabel tslblCount;
        private System.Windows.Forms.ToolStripLabel tslblCountCap;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkExists;
        private System.Windows.Forms.CheckBox chkDescription;
        private System.Windows.Forms.CheckBox chkModel;
        private System.Windows.Forms.CheckBox chkManufacturer;
        private System.Windows.Forms.CheckBox chkGroup;
        public System.Windows.Forms.TextBox txtDescription1;
        public System.Windows.Forms.ComboBox cmbGroup;
        public System.Windows.Forms.ComboBox cmbManufacturer;
        public System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
        private System.Windows.Forms.BindingSource bindingSourceManufacturers;
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
    }
}
