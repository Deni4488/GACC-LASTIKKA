using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowDemandContent : Form
    {
        int demand_id;
        // Инициализация формы
        public WindowDemandContent(int demand_id)
        {
            InitializeComponent();
            this.demand_id = demand_id;
        }
        // Загрузка формы
        private void Window_Load(object sender, EventArgs e)
        {
            // Загрузка данных содержимого запроса
            dgvData.Rows.Clear();
            DBImage.qdcldt = DBImage.qgclta.GetDataByByID(demand_id);
            if (DBImage.qdcldt.Rows.Count > 0)
            {
                for (int i = 0; i < DBImage.qdcldt.Rows.Count; i++)
                {
                    dgvData.Rows.Add();
                    dgvData.Rows[dgvData.RowCount - 1].Cells[0].Value = DBImage.qdcldt.Rows[i].ItemArray[1];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[1].Value = DBImage.qdcldt.Rows[i].ItemArray[11];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[2].Value = DBImage.qdcldt.Rows[i].ItemArray[12];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[3].Value = DBImage.qdcldt.Rows[i].ItemArray[6];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[4].Value = DBImage.qdcldt.Rows[i].ItemArray[2];
                }
            }
        }
        // -----------------------------------------------------------


        // -----------------------------------------------------------
        // Команды меню
        // -----------------------------------------------------------
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // временные значения
            int g_id;
            string g_man, g_grp, g_mdl;
            // формирование диалога выбора товаров
            DialogGoodsSelection dgs = new DialogGoodsSelection();
            if (dgs.ShowDialog() == DialogResult.OK)
            {
                if (dgs.dgvData.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgs.dgvData.SelectedRows.Count; i++)
                    {
                        g_id = Convert.ToInt32(dgs.dgvData.SelectedRows[i].Cells[0].Value);
                        g_grp = dgs.dgvData.SelectedRows[i].Cells[1].Value.ToString();
                        g_man = dgs.dgvData.SelectedRows[i].Cells[2].Value.ToString();
                        g_mdl = dgs.dgvData.SelectedRows[i].Cells[3].Value.ToString();
                        if (!goodContains(g_id))
                        {
                            // добавляем новую строку в таблицу 
                            dgvData.Rows.Add(new object[] { g_id, g_man, g_grp, g_mdl, 1 });
                        }
                    }
                }
            }
            dgs.Dispose();
        }
        // -----------------------------------------------------------
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                if (MessageBox.Show("Удалить выбранную строку ?", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // удаление записи из таблицы
                    dgvData.Rows.RemoveAt(selected_row);
                }
            }
        }
        // -----------------------------------------------------------
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Невозможно сохранить пустые данные!",
                                   Application.ProductName,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation);
                return;
            }

            if (Authorization.Access > 2)
            {
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    // удаление старого состава из бд
                    DBImage.dcta.ClearDemand(demand_id);
                    // добавление нового состава
                    txtF.Focus();
                    int count;
                    if (dgvData.RowCount > 0)
                    {
                        for (int i = 0; i < dgvData.RowCount; i++)
                        {
                            bool b = int.TryParse(dgvData.Rows[i].Cells[4].Value.ToString(), out count);
                            if (!b || count <= 0)
                            {
                                MessageBox.Show("Обнаружена некорректно введенное значение количества в строке " + (i + 1).ToString() + Environment.NewLine +
                                    "Значение будет заменено на корректное по умолчанию - 1.",
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvData.Rows[i].Cells[4].Value = 1;
                                count = 1;
                            }
                            DBImage.dcta.InsertQuery(demand_id, Convert.ToInt32(dgvData.Rows[i].Cells[0].Value), count);
                        }
                    }
                    MessageBox.Show("Обновлено успешно",
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // -----------------------------------------------------------
        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // -----------------------------------------------------------
        // поиск товара в таблице товаров запроса
        protected bool goodContains(int good_id)
        {
            bool ret_val = false;
            if (dgvData.Rows.Count > 0)
            {
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    if (good_id == Convert.ToInt32(dgvData.Rows[i].Cells[0].Value))
                    {
                        ret_val = true;
                        break;
                    }
                }
            }
            return ret_val;
        }
        // -----------------------------------------------------------------
    }
}