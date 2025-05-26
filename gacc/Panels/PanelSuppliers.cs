using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelSuppliers : UserControl
    {
        public PanelSuppliers()
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
            int rowsLoaded = DBImage.pta.FillByFilter(dbDataSet.providers, filter, filter, filter);
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
        int ID;
        string p_name, p_phone, p_account, p_contact, p_address;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogProvider dialog = new Dialogues.DialogProvider();
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                p_name = dialog.txtName.Text;
                p_contact = dialog.txtContact.Text;
                p_account = dialog.txtAccount.Text;
                p_phone = dialog.txtPhone.Text;
                p_address = dialog.txtAddress.Text;
                // обновление данных в БД
                DBImage.pta.InsertQuery(p_name, p_address, p_phone, p_contact, p_account);
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
                    p_name = dgvData.Rows[selected_row].Cells[1].Value.ToString();
                    p_contact = dgvData.Rows[selected_row].Cells[4].Value.ToString();
                    p_account = dgvData.Rows[selected_row].Cells[5].Value.ToString();
                    p_address = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                    p_phone = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogProvider dialog = new Dialogues.DialogProvider();
                    dialog.txtName.Text = p_name;
                    dialog.txtContact.Text = p_contact;
                    dialog.txtAccount.Text = p_account;
                    dialog.txtPhone.Text = p_phone;
                    dialog.txtAddress.Text = p_address;
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        p_name = dialog.txtName.Text;
                        p_contact = dialog.txtContact.Text;
                        p_account = dialog.txtAccount.Text;
                        p_phone = dialog.txtPhone.Text;
                        p_address = dialog.txtAddress.Text;
                        // обновление данных в БД
                        DBImage.pta.UpdateQuery(p_name, p_address, p_phone, p_contact, p_account, ID);
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
                        DBImage.pta.DeleteQuery(ID);
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
        private void tsbtnGoods_Click(object sender, EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                WindowProviderPrices wpp = new WindowProviderPrices(ID);
                wpp.ShowDialog();
            }
        }
        // ---------------------------------------------------------
    }
}