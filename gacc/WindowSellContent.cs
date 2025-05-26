using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowSellContent : Form
    {
        int counterparty_id;
        int shop_id;
        int sell_id;
        int counterparty_discount;
        // Инициализация формы
        public WindowSellContent(int counterparty_id, int shop_id, int sell_id)
        {
            InitializeComponent();
            this.counterparty_id = counterparty_id;
            this.shop_id = shop_id;
            this.sell_id = sell_id;
            // получение скидки клиента
            DBImage.cpldt = DBImage.cplta.GetDataByID(counterparty_id);
            int.TryParse(DBImage.cpldt.Rows[0].ItemArray[6].ToString(), out counterparty_discount);
            if (counterparty_id == 5) counterparty_discount *= 0;
            lblDiscount.Text = counterparty_discount.ToString() + " %";
            DBImage.cpldt.Dispose();
        }

        // Загрузка формы
        private void Window_Load(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
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
            decimal g_price;
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
                        g_price = Convert.ToInt32(dgs.dgvData.SelectedRows[i].Cells[6].Value);
                        if (!goodContains(g_id))
                        {
                            // добавляем новую строку в таблицу 
                            dgvData.Rows.Add(new object[] { g_id, g_man, g_grp, g_mdl, 1, g_price, g_price });
                        }
                    }
                }
            }
            dgs.Dispose();
            updateStatus();
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
                    updateStatus();
                }
            }
        }
        // -----------------------------------------------------------
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (Authorization.Access > 0)
            {
                if (dgvData.Rows.Count < 1)
                {
                    MessageBox.Show("Невозможно сохранить пустые данные!",
                                       Application.ProductName,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Exclamation);
                    return;
                }               
                
                // получение индекса выбранной строки
                int selected_row = dgvData.SelectedRows[0].Index;
                if (selected_row >= 0)
                {
                    // добавление состава
                    txtF.Focus();
                    int count, good_id, bcount;
                    decimal price;
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
                            txtF.Focus();
                            good_id = Convert.ToInt32(dgvData.Rows[i].Cells[0].Value);
                            price = Convert.ToDecimal(dgvData.Rows[i].Cells[5].Value);
                            DBImage.sellcta.InsertQuery(sell_id, good_id, count, price);

                            // получаем количество товара в магазине
                            txtF.Focus();
                            DBImage.gsdt = DBImage.gsta.GetGoodsCount(good_id, shop_id);
                            bcount = Convert.ToInt32(DBImage.gsdt.Rows[0].ItemArray[2]);
                            // обновляем количество
                            bcount -= count;
                            DBImage.gsta.UpdateCount(bcount, good_id, shop_id);
                            DBImage.gsdt.Dispose();
                        }
                    }
                    MessageBox.Show("Обновлено успешно",
                            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        // Расчет стоимости
        // -----------------------------------------------------------
        private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // обновление, если правилось количество
            if (e.ColumnIndex == 4) updateStatus();
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
        // -----------------------------------------------------------
        // -------------------- Расчет стоимости ---------------------
        private void updateStatus() // обновление строки статуса
        {
            decimal temp_q = 0, temp_p = 0, summ = 0, genSumm = 0, genQ = 0;
            if (dgvData.RowCount > 0)
            {
                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    // цена
                    decimal.TryParse(dgvData.Rows[i].Cells[5].Value.ToString(), out temp_p);
                    // проверка введенных значений - по полю "кол-во"                    
                    bool b = decimal.TryParse(dgvData.Rows[i].Cells[4].Value.ToString(), out temp_q);
                    if (!b)// если в поле "кол-во" введено некорректное                    
                    {      // значение, оно будет заменено единицей
                        temp_q = 1;
                        dgvData.Rows[i].Cells[4].Value = 1;
                    }
                    else
                    {
                        if (temp_q <= 0)
                        {
                            temp_q = 1;
                            dgvData.Rows[i].Cells[4].Value = 1;
                        }
                    }
                    // подсчет сумм
                    genQ += temp_q;
                    summ = temp_q * temp_p;
                    dgvData.Rows[i].Cells[6].Value = summ;
                    genSumm += summ;
                }
            }
            // добавление в расчет
            lblPositions.Text = dgvData.RowCount.ToString("00");
            lblGoodsCount.Text = genQ.ToString("00");
            lblSummary.Text = genSumm.ToString("C0");
            lblDiscountSum.Text = (genSumm - genSumm * counterparty_discount / 100).ToString("C0");
        }
        // -----------------------------------------------------------
    }
}