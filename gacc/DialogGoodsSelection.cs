using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class DialogGoodsSelection : Form
    {
        // Загрузка и инициализация формы
        public DialogGoodsSelection()
        {
            InitializeComponent();
            DBImage.gall.Fill(dbDataSet.query_GoodsAll);
        }

        // --------------------------------------------------------
        //   ДЕЙСТВИЯ МЕНЮ
        // --------------------------------------------------------
        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // --------------------------------------------------------
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        // --------------------------------------------------------
    }
}