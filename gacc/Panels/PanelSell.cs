using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelSell : UserControl
    {
        public PanelSell()
        {
            // инициализация компонента
            InitializeComponent();
            // диапазон дат по умолчанию
            // первый день текущего месяца
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-4);
            // последний день текущего месяца
            dtpTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1);
            // отображение данных с отключенным фильтром
            ApplyFilter("%");
        }
        // фильтрация данных
        protected void ApplyFilter(string filter)
        {
            // загрузить данные в таблицу
            int rowsLoaded = DBImage.qselllta.FillByFilter(dbDataSet.query_SellList,
                filter, dtpTo.Value, dtpFrom.Value,
                filter, dtpTo.Value, dtpFrom.Value,
                filter, dtpTo.Value, dtpFrom.Value);
            tslblCount.Text = rowsLoaded.ToString("00");
        }
        // ---------------------------------------------------------
        private void tstxtFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("%" + tstxtFilter.Text + "%");
        }
        // ---------------------------------------------------------


        // ---------------------------------------------------------
        /// <summary>
        ///  Управление - команды меню
        /// </summary>
        // ---------------------------------------------------------
        int ID, counterparty_id, shop_id;
        string seller, counterpart_name, shop_name;
        DateTime date;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogSell dialog = new Dialogues.DialogSell(0, 0, Authorization.UserName);
            dialog.dtpDate.Value = DateTime.Now.Date;
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                date = dialog.dtpDate.Value;
                seller = dialog.lblSeller.Text;
                counterparty_id = Convert.ToInt32(dialog.cmbCounterparty.SelectedValue);
                shop_id = Convert.ToInt32(dialog.cmbShop.SelectedValue);
                // обновление данных в БД
                DBImage.sellta.InsertQuery(date, seller, counterparty_id, shop_id);
                this.dbDataSet.AcceptChanges();
                ApplyFilter("%");
            }
            dialog.Dispose();
        }
        // ---------------------------------------------------------
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }
        // ---------------------------------------------------------
        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }
        // ---------------------------------------------------------
        protected void EditData()
        {
            if (Authorization.Access > 0)
            {
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    // считывание данных выбранной записи из таблицы
                    ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                    date = Convert.ToDateTime(dgvData.Rows[selected_row].Cells[1].Value);
                    seller = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                    counterpart_name = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                    shop_name = dgvData.Rows[selected_row].Cells[4].Value.ToString();
                    counterparty_id = Convert.ToInt32(dgvData.Rows[selected_row].Cells[5].Value);
                    shop_id = Convert.ToInt32(dgvData.Rows[selected_row].Cells[6].Value);
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogSell dialog = new Dialogues.DialogSell(counterparty_id, shop_id, seller);
                    dialog.dtpDate.Value = date;
                    dialog.cmbCounterparty.SelectedValue = counterparty_id;
                    dialog.cmbShop.SelectedValue = shop_id;
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        date = dialog.dtpDate.Value;
                        seller = dialog.lblSeller.Text;
                        counterparty_id = Convert.ToInt32(dialog.cmbCounterparty.SelectedValue);
                        shop_id = Convert.ToInt32(dialog.cmbShop.SelectedValue);
                        // обновление данных в БД
                        DBImage.sellta.UpdateQuery(date, seller, counterparty_id, shop_id, ID);
                        this.dbDataSet.AcceptChanges();
                        ApplyFilter("%");
                    }
                    dialog.Dispose();
                }
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав для совершения данного действия!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        // ---------------------------------------------------------
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Операция удаленя продажи невозможна! Обратитесь к администратору Базы данных.",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }
        // ---------------------------------------------------------
        private void tsbtnContent_Click(object sender, EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                shop_id = Convert.ToInt32(dgvData.Rows[selected_row].Cells[6].Value);
                counterparty_id = Convert.ToInt32(dgvData.Rows[selected_row].Cells[5].Value);
                // Если в продаже уже содержатся записи, значит она не новая
                if (DBImage.sellcta.GetDataByID(ID).Rows.Count > 0)
                {
                    MessageBox.Show("Изменить состав продажи невозможно!" + Environment.NewLine +
                                " - Для изменения состава продажи обратитесь к администратору Базы данных;" + Environment.NewLine +
                                " - Для просмотра данных продажи воспользуйтесь пунктом меню Документ.",
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    WindowSellContent wsc = new WindowSellContent(counterparty_id, shop_id, ID);
                    wsc.ShowDialog();
                }
            }          
        }
        // ---------------------------------------------------------
        private void tsbtnViewDocument_Click(object sender, EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                DocumentGenerator.ShowDocumentOfSell(ID);
            }
        }
        // ---------------------------------------------------------
    }
}