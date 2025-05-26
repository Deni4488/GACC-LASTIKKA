namespace gacc.Dialogues
{
    partial class DialogSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSupply));
            this.grpSeparator_2 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.lblSupplyDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProvider = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblShop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSeparator_2
            // 
            this.grpSeparator_2.Location = new System.Drawing.Point(7, 250);
            this.grpSeparator_2.Name = "grpSeparator_2";
            this.grpSeparator_2.Size = new System.Drawing.Size(367, 8);
            this.grpSeparator_2.TabIndex = 61;
            this.grpSeparator_2.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 154);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(136, 13);
            this.lblDescription.TabIndex = 60;
            this.lblDescription.Text = "Комментарий к поставке";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(7, 170);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(367, 74);
            this.txtDescription.TabIndex = 3;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSupplyDate
            // 
            this.lblSupplyDate.AutoSize = true;
            this.lblSupplyDate.Location = new System.Drawing.Point(106, 40);
            this.lblSupplyDate.Name = "lblSupplyDate";
            this.lblSupplyDate.Size = new System.Drawing.Size(73, 13);
            this.lblSupplyDate.TabIndex = 63;
            this.lblSupplyDate.Text = "Поставка от:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 8);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Location = new System.Drawing.Point(185, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(189, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataSource = this.providersBindingSource;
            this.cmbProvider.DisplayMember = "p_name";
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(7, 89);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(367, 21);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.ValueMember = "p_id";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(4, 73);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(65, 13);
            this.lblProvider.TabIndex = 58;
            this.lblProvider.Text = "Поставщик";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(196, 270);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 30);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(7, 6);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 59;
            this.picIcon.TabStop = false;
            // 
            // cmbShop
            // 
            this.cmbShop.DataSource = this.shopsBindingSource;
            this.cmbShop.DisplayMember = "s_address";
            this.cmbShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(7, 130);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(367, 21);
            this.cmbShop.TabIndex = 2;
            this.cmbShop.ValueMember = "s_id";
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataMember = "shops";
            this.shopsBindingSource.DataSource = this.dbDataSet;
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(4, 114);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(127, 13);
            this.lblShop.TabIndex = 65;
            this.lblShop.Text = "Магазин для разгрузки";
            // 
            // DialogSupply
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(383, 317);
            this.Controls.Add(this.cmbShop);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.grpSeparator_2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblSupplyDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogSupply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.DialogSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeparator_2;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.Label lblSupplyDate;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox picIcon;
        public System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.BindingSource shopsBindingSource;
    }
}