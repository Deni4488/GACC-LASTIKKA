using System;
using System.Windows.Forms;

namespace gacc
{
    public partial class WindowCounterpartySummary : Form
    {
        // Инициализация компонента
        public WindowCounterpartySummary()
        {
            InitializeComponent();
            // первый день текущего месяца
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            // последний день текущего месяца
            dtpTo.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1);
        }
        // -----------------------------------------------------------------
        // Обновление графика
        protected void UpdateChart()
        {
            // Дата и время
            DateTime dFrom = dtpFrom.Value;
            DateTime dTo = dtpTo.Value;
            // Обновление диаграммы
            tChart.Series[0].Clear();
            DBImage.qscp = DBImage.qscpta.GetDataByDateRange(dFrom, dTo);
            if (DBImage.qscp.Rows.Count > 0)
            {
                string counterparty;
                decimal summ;
                for (int i = 0; i < DBImage.qscp.Rows.Count; i++)
                {
                    summ = Convert.ToDecimal(DBImage.qscp.Rows[i].ItemArray[4]);
                    counterparty = DBImage.qscp.Rows[i].ItemArray[1].ToString();
                    tChart.Series[0].Add((float)(summ), counterparty);
                }
            }
        }
        // -----------------------------------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }
        // -----------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // -----------------------------------------------------------------
    }
}