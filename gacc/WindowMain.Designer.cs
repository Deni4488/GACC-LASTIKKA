namespace gacc
{
    partial class WindowMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.tstrMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnSuppliers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCounterparty = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShops = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCategories = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGoods = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSupply = new System.Windows.Forms.ToolStripButton();
            this.tsbtbDemands = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSells = new System.Windows.Forms.ToolStripButton();
            this.tsbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblDateTime = new System.Windows.Forms.ToolStripLabel();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlUserInterface = new System.Windows.Forms.Panel();
            this.tstrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstrMenu
            // 
            this.tstrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSuppliers,
            this.tsbtnCounterparty,
            this.tsbtnShops,
            this.toolStripSeparator1,
            this.tsbtnCategories,
            this.tsbtnGoods,
            this.toolStripSeparator2,
            this.tsbtnSupply,
            this.tsbtbDemands,
            this.tsbtnSells,
            this.tsbtnQuit,
            this.toolStripSeparator3,
            this.tsbtnLogin,
            this.toolStripSeparator4,
            this.tslblDateTime});
            this.tstrMenu.Location = new System.Drawing.Point(0, 0);
            this.tstrMenu.Name = "tstrMenu";
            this.tstrMenu.Size = new System.Drawing.Size(994, 86);
            this.tstrMenu.TabIndex = 0;
            this.tstrMenu.Text = "toolStrip1";
            // 
            // tsbtnSuppliers
            // 
            this.tsbtnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSuppliers.Image")));
            this.tsbtnSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSuppliers.Name = "tsbtnSuppliers";
            this.tsbtnSuppliers.Size = new System.Drawing.Size(81, 83);
            this.tsbtnSuppliers.Text = "Поставщики";
            this.tsbtnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSuppliers.Click += new System.EventHandler(this.tsbtnSuppliers_Click);
            // 
            // tsbtnCounterparty
            // 
            this.tsbtnCounterparty.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCounterparty.Image")));
            this.tsbtnCounterparty.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCounterparty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCounterparty.Name = "tsbtnCounterparty";
            this.tsbtnCounterparty.Size = new System.Drawing.Size(82, 83);
            this.tsbtnCounterparty.Text = "Контрагенты";
            this.tsbtnCounterparty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCounterparty.Click += new System.EventHandler(this.tsbtnCounterparty_Click);
            // 
            // tsbtnShops
            // 
            this.tsbtnShops.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShops.Image")));
            this.tsbtnShops.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnShops.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShops.Name = "tsbtnShops";
            this.tsbtnShops.Size = new System.Drawing.Size(68, 83);
            this.tsbtnShops.Text = "Магазины";
            this.tsbtnShops.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnShops.Click += new System.EventHandler(this.tsbtnShops_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // tsbtnCategories
            // 
            this.tsbtnCategories.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCategories.Image")));
            this.tsbtnCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCategories.Name = "tsbtnCategories";
            this.tsbtnCategories.Size = new System.Drawing.Size(68, 83);
            this.tsbtnCategories.Text = "Категории";
            this.tsbtnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCategories.Click += new System.EventHandler(this.tsbtnCategories_Click);
            // 
            // tsbtnGoods
            // 
            this.tsbtnGoods.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGoods.Image")));
            this.tsbtnGoods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGoods.Name = "tsbtnGoods";
            this.tsbtnGoods.Size = new System.Drawing.Size(92, 83);
            this.tsbtnGoods.Text = "Номенклатура";
            this.tsbtnGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnGoods.Click += new System.EventHandler(this.tsbtnGoods_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // tsbtnSupply
            // 
            this.tsbtnSupply.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSupply.Image")));
            this.tsbtnSupply.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSupply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSupply.Name = "tsbtnSupply";
            this.tsbtnSupply.Size = new System.Drawing.Size(68, 83);
            this.tsbtnSupply.Text = "Поставки";
            this.tsbtnSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSupply.Click += new System.EventHandler(this.tsbtnSupply_Click);
            // 
            // tsbtbDemands
            // 
            this.tsbtbDemands.Image = ((System.Drawing.Image)(resources.GetObject("tsbtbDemands.Image")));
            this.tsbtbDemands.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtbDemands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtbDemands.Name = "tsbtbDemands";
            this.tsbtbDemands.Size = new System.Drawing.Size(68, 83);
            this.tsbtbDemands.Text = "Запросы";
            this.tsbtbDemands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtbDemands.Click += new System.EventHandler(this.tsbtbDemands_Click);
            // 
            // tsbtnSells
            // 
            this.tsbtnSells.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSells.Image")));
            this.tsbtnSells.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSells.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSells.Name = "tsbtnSells";
            this.tsbtnSells.Size = new System.Drawing.Size(68, 83);
            this.tsbtnSells.Text = "Продажи";
            this.tsbtnSells.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSells.Click += new System.EventHandler(this.tsbtnSells_Click);
            // 
            // tsbtnQuit
            // 
            this.tsbtnQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuit.Image")));
            this.tsbtnQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuit.Name = "tsbtnQuit";
            this.tsbtnQuit.Size = new System.Drawing.Size(72, 83);
            this.tsbtnQuit.Text = "Завершить";
            this.tsbtnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnQuit.Click += new System.EventHandler(this.tsbtnQuit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // tsbtnLogin
            // 
            this.tsbtnLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogin.Image")));
            this.tsbtnLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogin.Name = "tsbtnLogin";
            this.tsbtnLogin.Size = new System.Drawing.Size(82, 83);
            this.tsbtnLogin.Text = "Авторизация";
            this.tsbtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnLogin.Click += new System.EventHandler(this.tsbtnLogin_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 86);
            // 
            // tslblDateTime
            // 
            this.tslblDateTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.tslblDateTime.Name = "tslblDateTime";
            this.tslblDateTime.Size = new System.Drawing.Size(110, 83);
            this.tslblDateTime.Text = "Now Date && Time...";
            this.tslblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // pnlUserInterface
            // 
            this.pnlUserInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInterface.Location = new System.Drawing.Point(0, 86);
            this.pnlUserInterface.Name = "pnlUserInterface";
            this.pnlUserInterface.Size = new System.Drawing.Size(994, 584);
            this.pnlUserInterface.TabIndex = 1;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 670);
            this.Controls.Add(this.pnlUserInterface);
            this.Controls.Add(this.tstrMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "WindowMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню: Учет товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowMain_FormClosing);
            this.tstrMenu.ResumeLayout(false);
            this.tstrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrMenu;
        private System.Windows.Forms.ToolStripButton tsbtnSuppliers;
        private System.Windows.Forms.ToolStripButton tsbtnCounterparty;
        private System.Windows.Forms.ToolStripButton tsbtnShops;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnCategories;
        private System.Windows.Forms.ToolStripButton tsbtnGoods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnSupply;
        private System.Windows.Forms.ToolStripButton tsbtbDemands;
        private System.Windows.Forms.ToolStripButton tsbtnSells;
        private System.Windows.Forms.ToolStripButton tsbtnQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tslblDateTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Panel pnlUserInterface;
    }
}

