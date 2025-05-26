using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogCategory : Form
    {
        // Загрузка компонента
        public DialogCategory()
        {
            InitializeComponent();
        }

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование категории!",
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