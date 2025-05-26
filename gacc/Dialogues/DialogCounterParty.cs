using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogCounterParty : Form
    {
        // Загрузка компонента
        public DialogCounterParty()
        {
            InitializeComponent();
        }

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование контрагента!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // Закрытие диалога, если все данные введены и корректны
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}