using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowGoodInStorages : Form
    {
        int good_id = 0;
        // Инициализация формы
        public WindowGoodInStorages(int good_id, string good)
        {
            InitializeComponent();
            this.good_id = good_id;
            lblDescr1.Text = good;
            // построение диаграммы
            UpdateChart();
        }

        // Обновление данных диаграммы
        private void UpdateChart()
        {
            // Обновление диаграммы
            tChart.Series[0].Clear();
            DBImage.gisdt = DBImage.gista.GetDataByGood(good_id);
            if (DBImage.gisdt.Rows.Count > 0)
            {
                string shop_address;
                decimal count;
                for (int i = 0; i < DBImage.gisdt.Rows.Count; i++)
                {
                    count = Convert.ToDecimal(DBImage.gisdt.Rows[i].ItemArray[4]);
                    shop_address = DBImage.gisdt.Rows[i].ItemArray[3].ToString();
                    tChart.Series[0].Add((float)(count), shop_address);
                }
            }
        }
    }
}