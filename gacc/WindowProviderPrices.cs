using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowProviderPrices : Form
    {
        int provider_id;
        // Инициализация формы
        public WindowProviderPrices(int provider_id)
        {
            InitializeComponent();
            this.provider_id = provider_id;
        }
        // Загрузка формы
        private void WindowProviderPrices_Load(object sender, EventArgs e)
        {
            // Загрузка данных товарной номенклатуры поставщика
            dgvData.Rows.Clear();
            DBImage.qppldt = DBImage.qpplta.GetDataByFilter(provider_id, "%",
                provider_id, "%", provider_id,
                "%", provider_id, "%",
                provider_id, "%");
            if (DBImage.qppldt.Rows.Count > 0)
            {
                for (int i = 0; i < DBImage.qppldt.Rows.Count; i++)
                {
                    dgvData.Rows.Add();
                    dgvData.Rows[dgvData.RowCount - 1].Cells[0].Value = DBImage.qppldt.Rows[i].ItemArray[1];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[1].Value = DBImage.qppldt.Rows[i].ItemArray[11];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[2].Value = DBImage.qppldt.Rows[i].ItemArray[12];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[3].Value = DBImage.qppldt.Rows[i].ItemArray[6];
                    dgvData.Rows[dgvData.RowCount - 1].Cells[4].Value = DBImage.qppldt.Rows[i].ItemArray[2];
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
                            dgvData.Rows.Add(new object[] { g_id, g_man, g_grp, g_mdl, 1000 });
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
            if (Authorization.Access > 2)
            {
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    // удаление старого состава из бд
                    DBImage.ppta.DeleteByProvider(provider_id);
                    // добавление нового состава
                    txtF.Focus();
                    decimal price;
                    if (dgvData.RowCount > 0)
                    {
                        for (int i = 0; i < dgvData.RowCount; i++)
                        {
                            bool b = decimal.TryParse(dgvData.Rows[i].Cells[4].Value.ToString(), out price);
                            if (!b || price <= 0)
                            {
                                MessageBox.Show("Обнаружена некорректно введенная цена в строке " + (i + 1).ToString() + Environment.NewLine +
                                    "Значение будет заменено на корректное по умолчанию - 1000.",
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvData.Rows[i].Cells[4].Value = 1000;
                                price = 1000;
                            }
                            DBImage.ppta.InsertQuery(provider_id, Convert.ToInt32(dgvData.Rows[i].Cells[0].Value), price);
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
        // поиск товара в таблице товаров поставщика
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