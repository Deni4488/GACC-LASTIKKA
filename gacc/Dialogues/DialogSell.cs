using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogSell : Form
    {
        int counterparty_id;
        int shop_id;
        string seller;
        // Инициализация формы
        public DialogSell(int counterparty_id, int shop_id, string seller)
        {
            InitializeComponent();
            this.counterparty_id = counterparty_id;
            this.shop_id = shop_id;
            this.seller = seller;
        }
        // Загрузка формы
        private void DialogSell_Load(object sender, EventArgs e)
        {
            // продавец
            lblSeller.Text = seller;
            // список поставщиков
            DBImage.cpta.Fill(dbDataSet.counterparties, "%", "%", "%");
            cmbCounterparty.SelectedValue = counterparty_id;
            // список магазинов
            DBImage.sta.Fill(dbDataSet.shops, "%");
            cmbShop.SelectedValue = shop_id;
        }
        // -----------------------------------------------------------

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbCounterparty.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные покупателя!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cmbShop.Text.Trim() == "")
            {
                MessageBox.Show("Укажите магазин из списка!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // Закрытие диалога, если все данные введены и корректны
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}