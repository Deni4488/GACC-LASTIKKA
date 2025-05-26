namespace gacc.Dialogues
{
    partial class DialogSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSell));
            this.grpSeparator_2 = new System.Windows.Forms.GroupBox();
            this.lblSellerCap = new System.Windows.Forms.Label();
            this.counterpartiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new gacc.dbDataSet();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSellDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCounterparty = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCounterparty = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counterpartiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSeparator_2
            // 
            this.grpSeparator_2.Location = new System.Drawing.Point(7, 183);
            this.grpSeparator_2.Name = "grpSeparator_2";
            this.grpSeparator_2.Size = new System.Drawing.Size(367, 8);
            this.grpSeparator_2.TabIndex = 75;
            this.grpSeparator_2.TabStop = false;
            // 
            // lblSellerCap
            // 
            this.lblSellerCap.AutoSize = true;
            this.lblSellerCap.Location = new System.Drawing.Point(4, 167);
            this.lblSellerCap.Name = "lblSellerCap";
            this.lblSellerCap.Size = new System.Drawing.Size(58, 13);
            this.lblSellerCap.TabIndex = 74;
            this.lblSellerCap.Text = "Оформил:";
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
            // cmbShop
            // 
            this.cmbShop.DataSource = this.shopsBindingSource;
            this.cmbShop.DisplayMember = "s_address";
            this.cmbShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(7, 131);
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
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Location = new System.Drawing.Point(106, 41);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(70, 13);
            this.lblSellDate.TabIndex = 77;
            this.lblSellDate.Text = "Продажа от:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 8);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Location = new System.Drawing.Point(185, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(189, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // cmbCounterparty
            // 
            this.cmbCounterparty.DataSource = this.counterpartiesBindingSource;
            this.cmbCounterparty.DisplayMember = "c_name";
            this.cmbCounterparty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounterparty.FormattingEnabled = true;
            this.cmbCounterparty.Location = new System.Drawing.Point(7, 90);
            this.cmbCounterparty.Name = "cmbCounterparty";
            this.cmbCounterparty.Size = new System.Drawing.Size(367, 21);
            this.cmbCounterparty.TabIndex = 1;
            this.cmbCounterparty.ValueMember = "c_id";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblCounterparty
            // 
            this.lblCounterparty.AutoSize = true;
            this.lblCounterparty.Location = new System.Drawing.Point(4, 74);
            this.lblCounterparty.Name = "lblCounterparty";
            this.lblCounterparty.Size = new System.Drawing.Size(67, 13);
            this.lblCounterparty.TabIndex = 72;
            this.lblCounterparty.Text = "Покупатель";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(197, 202);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 30);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(7, 7);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 73;
            this.picIcon.TabStop = false;
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(4, 115);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(51, 13);
            this.lblShop.TabIndex = 78;
            this.lblShop.Text = "Магазин";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeller.ForeColor = System.Drawing.Color.Blue;
            this.lblSeller.Location = new System.Drawing.Point(68, 167);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(152, 13);
            this.lblSeller.TabIndex = 79;
            this.lblSeller.Text = "Фамилия Имя продавца";
            // 
            // DialogSell
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(386, 246);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.grpSeparator_2);
            this.Controls.Add(this.lblSellerCap);
            this.Controls.Add(this.cmbShop);
            this.Controls.Add(this.lblSellDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCounterparty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCounterparty);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogSell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.DialogSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counterpartiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeparator_2;
        private System.Windows.Forms.Label lblSellerCap;
        private System.Windows.Forms.BindingSource counterpartiesBindingSource;
        private dbDataSet dbDataSet;
        public System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.ComboBox cmbCounterparty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCounterparty;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblShop;
        public System.Windows.Forms.Label lblSeller;
    }
}