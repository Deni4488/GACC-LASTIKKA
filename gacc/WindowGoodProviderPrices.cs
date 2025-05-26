using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowGoodProviderPrices : Form
    {
        int good_id = 0;
        // Инициализация формы
        public WindowGoodProviderPrices(int good_id, string good)
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
            DBImage.ppdt = DBImage.qpp.GetDataByGood(good_id);
            if (DBImage.ppdt.Rows.Count > 0)
            {
                string provider;
                decimal price;

                for (int i = 0; i < DBImage.ppdt.Rows.Count; i++)
                {
                    price = Convert.ToDecimal(DBImage.ppdt.Rows[i].ItemArray[2]);
                    provider = DBImage.ppdt.Rows[i].ItemArray[4].ToString();
                    tChart.Series[0].Add((float)(price), provider);
                }
            }
        }
    }
}