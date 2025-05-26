using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogDemand : Form
    {
        int provider_id;
        // Инициализация формы
        public DialogDemand(int provider_id)
        {
            InitializeComponent();
            this.provider_id = provider_id;
        }
        // Загрузка формы
        private void DialogDemand_Load(object sender, EventArgs e)
        {
            // список поставщиков
            DBImage.pta.Fill(dbDataSet.providers);
            cmbProvider.SelectedValue = provider_id;
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
            // Закрытие диалога, если все данные введены и корректны
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}