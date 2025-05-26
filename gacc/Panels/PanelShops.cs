using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelShops : UserControl
    {
        public PanelShops()
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
            int rowsLoaded = DBImage.sta.Fill(dbDataSet.shops, filter);
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
        string s_name, s_phone, s_address;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogShop dialog = new Dialogues.DialogShop();
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                s_name = dialog.txtName.Text;
                s_phone = dialog.txtPhone.Text;
                s_address = dialog.txtAddress.Text;
                // обновление данных в БД
                DBImage.sta.InsertQuery(s_name, s_address, s_phone);
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
                    s_name = dgvData.Rows[selected_row].Cells[1].Value.ToString();
                    s_address = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                    s_phone = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogShop dialog = new Dialogues.DialogShop();
                    dialog.txtName.Text = s_name;
                    dialog.txtPhone.Text = s_phone;
                    dialog.txtAddress.Text = s_address;
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        s_name = dialog.txtName.Text;
                        s_phone = dialog.txtPhone.Text;
                        s_address = dialog.txtAddress.Text;
                        // обновление данных в БД
                        DBImage.sta.UpdateQuery(s_name, s_address, s_phone, ID);
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
                        DBImage.sta.DeleteQuery(ID);
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
    }
}