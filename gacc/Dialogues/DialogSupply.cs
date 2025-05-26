using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogSupply : Form
    {
        int provider_id;
        int shop_id;
        // Инициализация формы
        public DialogSupply(int provider_id, int shop_id)
        {
            InitializeComponent();
            this.provider_id = provider_id;
            this.shop_id = shop_id;
        }
        // Загрузка формы
        private void DialogSupply_Load(object sender, EventArgs e)
        {
            // список поставщиков
            DBImage.pta.Fill(dbDataSet.providers);
            cmbProvider.SelectedValue = provider_id;
            // список магазинов
            DBImage.sta.Fill(dbDataSet.shops, "%");
            cmbShop.SelectedValue = shop_id;
        }
        // -----------------------------------------------------------

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbProvider.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование поставщика!",
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