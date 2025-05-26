using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelCategories : UserControl
    {
        public PanelCategories()
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
            int rowsLoaded = DBImage.grta.Fill(dbDataSet.groups, filter);
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
        string gname;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogCategory dialog = new Dialogues.DialogCategory();
            dialog.txtCategoryName.Text = "";
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                gname = dialog.txtCategoryName.Text;
                // обновление данных в БД
                DBImage.grta.InsertQuery(gname);
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
                    gname = dgvData.Rows[selected_row].Cells[1].Value.ToString();
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogCategory dialog = new Dialogues.DialogCategory();
                    dialog.txtCategoryName.Text = gname;
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        gname = dialog.txtCategoryName.Text;
                        // обновление данных в БД
                        DBImage.grta.UpdateQuery(gname, ID);
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
                        DBImage.grta.DeleteQuery(ID);
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