using System;
using System.Windows.Forms;

namespace gacc.Dialogues
{
    public partial class DialogGood : Form
    {
        int id_group;
        int id_manufacturer;
        // Загрузка компонента
        public DialogGood(int id_group, int id_manufacturer)
        {
            InitializeComponent();
            this.id_group = id_group;
            this.id_manufacturer = id_manufacturer;
        }

        // Подтверждение данных
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbGroup.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование номенклатурной группы!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cmbManufacturer.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование производителя!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtModel.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Наименование марки (модели, спецификации)!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные в поле Стоимость!",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            decimal price = 0;
            bool b = decimal.TryParse(txtPrice.Text, out price);
            if (!b)
            {
                MessageBox.Show("В поле Стоимость введены некорректные данные!",
                                    Application.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Стоимость не может быть нулевой или меньше!",
                                    Application.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return;
            }
            // Закрытие диалога, если все данные введены и корректны
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Загрузка списков
        private void DialogGood_Load(object sender, EventArgs e)
        {
            // список производителей
            DBImage.mta.Fill(dbDataSet.manufacturers);
            cmbManufacturer.SelectedValue = id_manufacturer;
            // список номенклатурных групп
            DBImage.grta.Fill(dbDataSet.groups, "%");
            cmbGroup.SelectedValue = id_group;
        }
    }
}