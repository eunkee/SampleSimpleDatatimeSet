using System;
using System.Windows.Forms;

namespace SampleSimpleDatatimeSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //현재 월 1일 ~ 현재 월 일
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = new(DateTime.Today.Year, DateTime.Today.Month, 1, 0, 0, 0);
            DateTime endDateTime = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59, 999);

            dateTimePicker1.Value = startDateTime;
            dateTimePicker2.Value = endDateTime;
        }

        //현재 연 1월 1일 ~ 현재 월 일
        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = new(DateTime.Today.Year, 1, 1, 0, 0, 0);
            DateTime endDateTime = new(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59, 999);

            dateTimePicker1.Value = startDateTime;
            dateTimePicker2.Value = endDateTime;
        }

        //지난 월 1일 ~ 지난 월 마지막 일
        private void Button3_Click(object sender, EventArgs e)
        {
            DateTime lastMonthFirstDay = DateTime.Today.AddMonths(-1);
            DateTime startDateTime = new(lastMonthFirstDay.Year, lastMonthFirstDay.Month, 1, 0, 0, 0);
            DateTime lastMonthLastDay = startDateTime.AddMonths(1).AddDays(-1);
            DateTime endDateTime = new(lastMonthLastDay.Year, lastMonthLastDay.Month, lastMonthLastDay.Day, 23, 59, 59, 999);

            dateTimePicker1.Value = startDateTime;
            dateTimePicker2.Value = endDateTime;
        }

        //작년 1월 1일 ~ 작년 마지막 일
        private void Button4_Click(object sender, EventArgs e)
        {
            DateTime aYearAgo = DateTime.Today.AddYears(-1);
            DateTime startDateTime = new(aYearAgo.Year, 1, 1, 0, 0, 0);
            DateTime endDateTime = new(aYearAgo.Year, 12, 31, 23, 59, 59, 999);

            dateTimePicker1.Value = startDateTime;
            dateTimePicker2.Value = endDateTime;
        }
    }
}
