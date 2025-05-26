namespace gacc.Panels
{
    partial class PanelCounterparties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCounterparties));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.stsepSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStatistic = new System.Windows.Forms.ToolStripButton();
            this.tstrStatusBar = new System.Windows.Forms.ToolStrip();
            this.tslblFilter = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tslblCount = new System.Windows.Forms.ToolStripLabel();
            this.tslblCountCap = new System.Windows.Forms.ToolStripLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontactnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counterpartiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.tstrMenu.SuspendLayout();
            this.tstrStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartiesBindingSource)).BeginInit();
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
            this.tsbtnStatistic});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(987, 38);
            this.tstrMenu.TabIndex = 6;
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
            // tsbtnStatistic
            // 
            this.tsbtnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStatistic.Image")));
            this.tsbtnStatistic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStatistic.Name = "tsbtnStatistic";
            this.tsbtnStatistic.Size = new System.Drawing.Size(153, 35);
            this.tsbtnStatistic.Text = "Доходность контрагентов";
            this.tsbtnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStatistic.Click += new System.EventHandler(this.tsbtnStatistic_Click);
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
            this.tstrStatusBar.Location = new System.Drawing.Point(0, 550);
            this.tstrStatusBar.Name = "tstrStatusBar";
            this.tstrStatusBar.Size = new System.Drawing.Size(987, 25);
            this.tstrStatusBar.TabIndex = 7;
            // 
            // tslblFilter
            // 
            this.tslblFilter.Name = "tslblFilter";
            this.tslblFilter.Size = new System.Drawing.Size(62, 22);
            this.tslblFilter.Text = "Фильтр:";
            // 
            // tstxtFilter
            // 
            this.tstxtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstxtFilter.Name = "tstxtFilter";
            this.tstxtFilter.Size = new System.Drawing.Size(100, 25);
            this.tstxtFilter.TextChanged += new System.EventHandler(this.tstxtFilter_TextChanged);
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
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.ccontactnameDataGridViewTextBoxColumn,
            this.cphoneDataGridViewTextBoxColumn,
            this.cdescriptionDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.counterpartiesBindingSource;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(3, 39);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(981, 508);
            this.dgvData.TabIndex = 8;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Format = "0000";
            this.cidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cidDataGridViewTextBoxColumn.HeaderText = "_ID_";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cidDataGridViewTextBoxColumn.Width = 60;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cnameDataGridViewTextBoxColumn.FillWeight = 30F;
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccontactnameDataGridViewTextBoxColumn
            // 
            this.ccontactnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccontactnameDataGridViewTextBoxColumn.DataPropertyName = "c_contactname";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ccontactnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ccontactnameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.ccontactnameDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.ccontactnameDataGridViewTextBoxColumn.Name = "ccontactnameDataGridViewTextBoxColumn";
            this.ccontactnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cphoneDataGridViewTextBoxColumn
            // 
            this.cphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cphoneDataGridViewTextBoxColumn.DataPropertyName = "c_phone";
            this.cphoneDataGridViewTextBoxColumn.FillWeight = 15F;
            this.cphoneDataGridViewTextBoxColumn.HeaderText = "Для связи";
            this.cphoneDataGridViewTextBoxColumn.Name = "cphoneDataGridViewTextBoxColumn";
            this.cphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cdescriptionDataGridViewTextBoxColumn
            // 
            this.cdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdescriptionDataGridViewTextBoxColumn.DataPropertyName = "c_description";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cdescriptionDataGridViewTextBoxColumn.FillWeight = 35F;
            this.cdescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.cdescriptionDataGridViewTextBoxColumn.Name = "cdescriptionDataGridViewTextBoxColumn";
            this.cdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // counterpartiesBindingSource
            // 
            this.counterpartiesBindingSource.DataMember = "counterparties";
            this.counterpartiesBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelCounterparties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tstrMenu);
            this.Controls.Add(this.tstrStatusBar);
            this.Name = "PanelCounterparties";
            this.Size = new System.Drawing.Size(987, 575);
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            this.tstrStatusBar.ResumeLayout(false);
            this.tstrStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStrip tstrStatusBar;
        private System.Windows.Forms.ToolStripLabel tslblFilter;
        private System.Windows.Forms.ToolStripTextBox tstxtFilter;
        private System.Windows.Forms.ToolStripLabel tslblCount;
        private System.Windows.Forms.ToolStripLabel tslblCountCap;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource counterpartiesBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontactnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator stsepSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnStatistic;
    }
}
