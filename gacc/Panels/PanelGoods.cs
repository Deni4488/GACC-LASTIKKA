using System;
using System.Windows.Forms;

namespace gacc.Panels
{
    public partial class PanelGoods : UserControl
    {
        // Загрузка компонента
        public PanelGoods()
        {
            InitializeComponent();
            // Загрузка списков
            // список производителей
            DBImage.mta.Fill(dbDataSet.manufacturers);
            // список номенклатурных групп
            DBImage.grta.Fill(dbDataSet.groups, "%");
            // отображение данных
            ApplyFilter();
        }
        // фильтрация данных
        protected void ApplyFilter()
        {
            string f_gr = chkGroup.Checked ? "%" + cmbGroup.Text + "%" : "%";
            string f_model = chkModel.Checked ? "%" + txtModel.Text + "%" : "%";
            string f_man = chkManufacturer.Checked ? "%" + cmbManufacturer.Text + "%" : "%";
            string f_desc = chkDescription.Checked ? "%" + txtDescription1.Text + "%" : "%";
            decimal f_exist = chkExists.Checked ? 0 : -1;
            // загрузить данные в таблицу
            int rowsLoaded = DBImage.gall.FillByFilter(dbDataSet.query_GoodsAll,
                f_model, f_desc, f_exist, f_man, f_gr, f_model, f_desc, f_exist, f_man, f_gr);
            tslblCount.Text = rowsLoaded.ToString("00");
        }
        // ---------------------------------------------------------
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            ApplyFilter();
        }
        // ---------------------------------------------------------
        private void btnResetFilter_Click(object sender, System.EventArgs e)
        {
            chkGroup.Checked = false;
            chkModel.Checked = false;
            chkManufacturer.Checked = false;
            chkDescription.Checked = false;
            chkExists.Checked = false;
            txtDescription1.Text = "";
            txtModel.Text = "";
            ApplyFilter();
        }
        // ---------------------------------------------------------


        // ---------------------------------------------------------
        /// <summary>
        ///  Управление - команды меню
        /// </summary>
        // ---------------------------------------------------------
        int ID, group_ID, manufacturer_ID, quantity;
        string model, descr1, descr2, gname, mname;
        decimal price;
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // создание диалога ввода/редактирования данных
            Dialogues.DialogGood dialog = new Dialogues.DialogGood(0, 0);
            if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
            {
                // получение новых данных из диалога
                group_ID = Convert.ToInt32(dialog.cmbGroup.SelectedValue);
                manufacturer_ID = Convert.ToInt32(dialog.cmbManufacturer.SelectedValue);
                model = dialog.txtModel.Text;
                descr1 = dialog.txtDescription1.Text;
                descr2 = dialog.txtDescription2.Text;
                price = Convert.ToDecimal(dialog.txtPrice.Text);
                // обновление данных в БД
                DBImage.gta.InsertQuery(manufacturer_ID, group_ID, model, descr1, descr2, price);
                // получение ID только что добавленного товара
                int new_id = Convert.ToInt32(DBImage.gta.GetLastAddedID());
                // добавление позиции в магазины
                DBImage.sdt = DBImage.sta.GetData("%");
                if (DBImage.sdt.Rows.Count > 0)
                {
                    for (int i = 0, shop_id = 0; i < DBImage.sdt.Rows.Count; i++)
                    {
                        shop_id = Convert.ToInt32(DBImage.sdt.Rows[i].ItemArray[0]);
                        DBImage.gsta.InsertQuery(new_id, shop_id, 0);
                    }
                }
                DBImage.sdt.Dispose();
                this.dbDataSet.AcceptChanges();
                ApplyFilter();
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
                    mname = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                    model = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                    descr1 = dgvData.Rows[selected_row].Cells[4].Value.ToString();
                    descr2 = dgvData.Rows[selected_row].Cells[5].Value.ToString();
                    price = Convert.ToDecimal(dgvData.Rows[selected_row].Cells[6].Value);
                    quantity = Convert.ToInt32(dgvData.Rows[selected_row].Cells[7].Value);
                    group_ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[9].Value);
                    manufacturer_ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[8].Value);
                    // создание диалога ввода/редактирования данных
                    Dialogues.DialogGood dialog = new Dialogues.DialogGood(group_ID, manufacturer_ID);
                    dialog.cmbGroup.SelectedValue = group_ID;
                    dialog.cmbManufacturer.SelectedValue = manufacturer_ID;
                    dialog.txtModel.Text = model;
                    dialog.txtDescription1.Text = descr1;
                    dialog.txtDescription2.Text = descr2;
                    dialog.txtPrice.Text = price.ToString();
                    if (dialog.ShowDialog() == DialogResult.OK) // обновление данных
                    {
                        // получение новых данных из диалога
                        group_ID = Convert.ToInt32(dialog.cmbGroup.SelectedValue);
                        manufacturer_ID = Convert.ToInt32(dialog.cmbManufacturer.SelectedValue);
                        model = dialog.txtModel.Text;
                        descr1 = dialog.txtDescription1.Text;
                        descr2 = dialog.txtDescription2.Text;
                        price = Convert.ToDecimal(dialog.txtPrice.Text);
                        // обновление данных в БД
                        DBImage.gta.UpdateQuery(manufacturer_ID, group_ID, model, descr1, descr2, price, ID);
                        this.dbDataSet.AcceptChanges();
                        ApplyFilter();
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
                        DBImage.gta.DeleteQuery(ID);
                        dbDataSet.AcceptChanges();
                        ApplyFilter();
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
        private void tsbtnProviderPrices_Click(object sender, System.EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                // считывание данных выбранной записи из таблицы
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                gname = dgvData.Rows[selected_row].Cells[1].Value.ToString();
                mname = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                model = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                // вызов формы цен поставщиков
                WindowGoodProviderPrices wgpp = new WindowGoodProviderPrices(ID, gname + ": " + mname + ", " + model);
                wgpp.ShowDialog();
            }
        }
        // ---------------------------------------------------------
        private void tsbtnCounts_Click(object sender, System.EventArgs e)
        {
            // получение индекса выбранной строки
            int selected_row = dgvData.SelectedRows[0].Index;
            if (selected_row >= 0)
            {
                // считывание данных выбранной записи из таблицы
                ID = Convert.ToInt32(dgvData.Rows[selected_row].Cells[0].Value);
                gname = dgvData.Rows[selected_row].Cells[1].Value.ToString();
                mname = dgvData.Rows[selected_row].Cells[2].Value.ToString();
                model = dgvData.Rows[selected_row].Cells[3].Value.ToString();
                // вызов формы остатков
                WindowGoodInStorages wgis = new WindowGoodInStorages(ID, gname + ": " + mname + ", " + model);
                wgis.ShowDialog();
            }
        }
        // ---------------------------------------------------------
    }
}