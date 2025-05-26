namespace gacc.Dialogues
{
    partial class DialogGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogGood));
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpSeparator_1 = new System.Windows.Forms.GroupBox();
            this.grpSeparator_2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(5, 8);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 20;
            this.picIcon.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(538, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(347, 9);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(86, 13);
            this.lblManufacturer.TabIndex = 19;
            this.lblManufacturer.Text = "Производитель";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(65, 74);
            this.txtModel.MaxLength = 255;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(560, 20);
            this.txtModel.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(448, 266);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 30);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataSource = this.manufacturersBindingSource;
            this.cmbManufacturer.DisplayMember = "m_name";
            this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(350, 25);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(277, 21);
            this.cmbManufacturer.TabIndex = 1;
            this.cmbManufacturer.ValueMember = "m_id";
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "manufacturers";
            this.manufacturersBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.groupsBindingSource;
            this.cmbGroup.DisplayMember = "g_name";
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(65, 25);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(277, 21);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.ValueMember = "g_id";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.dbDataSet;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(62, 9);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(130, 13);
            this.lblGroup.TabIndex = 22;
            this.lblGroup.Text = "Номенклатурная группа";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(62, 58);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(275, 13);
            this.lblModel.TabIndex = 24;
            this.lblModel.Text = "Наименование модели (обозначение спецификации)";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(62, 107);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(92, 13);
            this.lblDescription1.TabIndex = 26;
            this.lblDescription1.Text = "Блок описания 1";
            // 
            // txtDescription1
            // 
            this.txtDescription1.Location = new System.Drawing.Point(65, 123);
            this.txtDescription1.MaxLength = 255;
            this.txtDescription1.Multiline = true;
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.Size = new System.Drawing.Size(277, 74);
            this.txtDescription1.TabIndex = 3;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(347, 107);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(92, 13);
            this.lblDescription2.TabIndex = 28;
            this.lblDescription2.Text = "Блок описания 2";
            // 
            // txtDescription2
            // 
            this.txtDescription2.Location = new System.Drawing.Point(350, 123);
            this.txtDescription2.MaxLength = 255;
            this.txtDescription2.Multiline = true;
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.Size = new System.Drawing.Size(277, 74);
            this.txtDescription2.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(427, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 13);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Цена продажи:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(516, 217);
            this.txtPrice.MaxLength = 255;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // grpSeparator_1
            // 
            this.grpSeparator_1.Location = new System.Drawing.Point(416, 203);
            this.grpSeparator_1.Name = "grpSeparator_1";
            this.grpSeparator_1.Size = new System.Drawing.Size(211, 8);
            this.grpSeparator_1.TabIndex = 31;
            this.grpSeparator_1.TabStop = false;
            // 
            // grpSeparator_2
            // 
            this.grpSeparator_2.Location = new System.Drawing.Point(65, 249);
            this.grpSeparator_2.Name = "grpSeparator_2";
            this.grpSeparator_2.Size = new System.Drawing.Size(562, 8);
            this.grpSeparator_2.TabIndex = 32;
            this.grpSeparator_2.TabStop = false;
            // 
            // DialogGood
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(637, 309);
            this.Controls.Add(this.grpSeparator_2);
            this.Controls.Add(this.grpSeparator_1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.txtDescription2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.txtDescription1);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogGood";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.DialogGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblManufacturer;
        public System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDescription1;
        public System.Windows.Forms.TextBox txtDescription1;
        private System.Windows.Forms.Label lblDescription2;
        public System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox grpSeparator_1;
        private System.Windows.Forms.GroupBox grpSeparator_2;
        public System.Windows.Forms.ComboBox cmbGroup;
        public System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
    }
}