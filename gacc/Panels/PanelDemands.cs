using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelDemands : UserControl
    {
        public PanelDemands()
        {
            // инициализация компонента
            InitializeComponent();
            // отображение данных с отключенным фильтром
            ApplyFilter("%");
        }
        // фильтрация данных
        protected void ApplyFilter(string filter)
        {
            // загрузить данные в таблицу
            int rowsLoaded = DBImage.qdlta.FillByFilter(dbDataSet.query_DemandsList, filter, filter);
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
        int ID, provider_id;
        string descr, provider_name;
        DateTime date;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogDemand dialog = new Dialogues.DialogDemand(0);
            dialog.dtpDate.Value = DateTime.Now.Date;
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                descr = dialog.txtDescription.Text;
                date = dialog.dtpDate.Value;
                provider_id = Convert.ToInt32(dialog.cmbProvider.SelectedValue);
                // обновление данных в БД
                DBImage.dta.InsertQuery(date, descr, provider_id);
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
            if (Authorization.Access > 1)
            {
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    // считывание данных выбранной записи из таблицы
                    ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                    date = Convert.ToDateTime(dgvData.Rows[selected_row].Cells[1].Value);
                    descr = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                    provider_name = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                    provider_id = Convert.ToInt32(dgvData.Rows[selected_row].Cells[4].Value);
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogDemand dialog = new Dialogues.DialogDemand(provider_id);
                    dialog.txtDescription.Text = descr;
                    dialog.dtpDate.Value = date;
                    dialog.cmbProvider.SelectedValue = provider_id;
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        descr = dialog.txtDescription.Text;
                        date = dialog.dtpDate.Value;
                        provider_id = Convert.ToInt32(dialog.cmbProvider.SelectedValue);
                        // обновление данных в БД
                        DBImage.dta.UpdateQuery(date, descr, provider_id, ID);
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
            if (Authorization.Access > 2)
            {
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                    if (MessageBox.Show("Удалить выбранную запись ?", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // удаление записи из БД
                        DBImage.dta.DeleteQuery(ID);
                        dbDataSet.AcceptChanges();
                        ApplyFilter("%");
                    }
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
        private void tsbtnContent_Click(object sender, EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                WindowDemandContent wdc = new WindowDemandContent(ID);
                wdc.ShowDialog();
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
                DocumentGenerator.ShowDocumentOfDemand(ID);
            }
        }
        // ---------------------------------------------------------
    }
}