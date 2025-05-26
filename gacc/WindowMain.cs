using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowMain : Form
    {
        /// ------------------------------------------------------------
        /// <summary>
        /// Загрузка и инициализация
        /// </summary>
        /// ------------------------------------------------------------
        public WindowMain()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            pnlUserInterface.Controls.Clear();
        }
        /// ------------------------------------------------------------


        /// ------------------------------------------------------------
        /// АВТОРИЗАЦИЯ
        /// ------------------------------------------------------------
        private void tsbtnLogin_Click(object sender, EventArgs e)
        {
            if (!Authorization.Authorize())
            {
                MessageBox.Show("Неверно введены данные авторизации!",
                    Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.Text = "Главное меню: Учет товаров [сеанс: " +
                    Authorization.UserName + "]";
            }
            Init();
        }
        /// ------------------------------------------------------------

        // загруженная в данный момент панель пользовательского иннтерфейса
        UserControl ucCurrentUserPanel = null;
        /// ------------------------------------------------------------
        ///  ДЕЙСТВИЯ МЕНЮ
        /// ------------------------------------------------------------
        private void tsbtnSuppliers_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelSuppliers();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnCounterparty_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelCounterparties();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnShops_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelShops();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnCategories_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelCategories();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnGoods_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelGoods();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnSupply_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelSupplies();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtbDemands_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelDemands();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        private void tsbtnSells_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                // удаление из памяти предыдущей загруженной подсистемы (если была)
                if (ucCurrentUserPanel != null) ucCurrentUserPanel.Dispose();
                // загрузка выбранной панели
                ucCurrentUserPanel = new Panels.PanelSell();
                LoadDataView(ucCurrentUserPanel);
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для доступа к даннйо функции!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        /// ------------------------------------------------------------
        // Загрузка данных выбранной панели
        protected void LoadDataView(UserControl uc)
        {
            pnlUserInterface.Controls.Clear();
            pnlUserInterface.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        /// ------------------------------------------------------------
        private void tsbtnQuit_Click(object sender, EventArgs e)
        {
            // action performs in closing event
            this.Close();
        }
        private void WindowMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Завершить работу программы ?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { e.Cancel = true; }
        }
        /// ------------------------------------------------------------


        /// ------------------------------------------------------------
        /// <summary>
        ///  Оновление текущей даты времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// ------------------------------------------------------------
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            tslblDateTime.Text = DateTime.Now.Date.ToLongDateString() +
                                Environment.NewLine +
                                DateTime.Now.ToShortTimeString();
        }
        /// ------------------------------------------------------------
    }
}