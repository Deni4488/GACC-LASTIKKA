using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogShop : Form
    {
        // Загрузка компонента
        public DialogShop()
        {
            InitializeComponent();
        }

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование!",
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