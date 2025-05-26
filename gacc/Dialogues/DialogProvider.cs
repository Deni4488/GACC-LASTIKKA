using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogProvider : Form
    {
        // Загрузка компонента
        public DialogProvider()
        {
            InitializeComponent();
        }

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование организации поставщика!",
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