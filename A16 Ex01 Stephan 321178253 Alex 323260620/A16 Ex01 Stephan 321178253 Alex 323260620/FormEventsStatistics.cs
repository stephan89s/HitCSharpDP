using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormEventsStatistics : Form
    {
        private List<ApplicationEvent> EventsList
        { get; }
        public FormEventsStatistics(List<ApplicationEvent> i_EventsList)
        {
            InitializeComponent();
            EventsList = i_EventsList;

        }
        private void startCount7days(int index, DateTime? i_date)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            int amountOfEvents = 0;
            int days = 1;
            DateTime? date = i_date;

            for (int i = index; i >= 0; i--)
            {
                int comparison = EventsList[i].StartTime.Value.Date.CompareTo(date);
                if (comparison == 0)
                {
                    amountOfEvents++;
                }
                else
                {
                    series.Points.AddXY(date, amountOfEvents);
                    amountOfEvents = 0;
                    i++;
                    date.Value.AddDays(1);
                    days++;
                    if (days > 7)
                    {
                        break;
                    }

                }
            }
            while (days < 8)
            {
                series.Points.AddXY(date, amountOfEvents);
                amountOfEvents = 0;
                days++;
            }
            chartEventsStatistics.Series.Clear();
            chartEventsStatistics.Series.Add(series);
        }

        private void dateOver(int index, DateTime? i_dateChoosed)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            int amountOfEvents = 0;

            int days = 1;
            DateTime? date = i_dateChoosed;


            for (int i = index; i >= 0; i--)
            {
                int comparison = EventsList[i].StartTime.Value.Date.CompareTo(date);
                if (comparison == 1)
                {

                    series.Points.AddXY(date, amountOfEvents);
                    amountOfEvents = 0;
                    i++;
                    i_dateChoosed.Value.AddDays(1);
                    days++;
                    if (days > 7)
                    {
                        break;
                    }
                }
                else
                {
                    amountOfEvents++;

                }


            }
           
            while (days < 8)
            {
                series.Points.AddXY(date, amountOfEvents);
                amountOfEvents = 0;
                days++;
            }
            chartEventsStatistics.Series.Clear();
            chartEventsStatistics.Series.Add(series);
        }

        private void initChart()
        {
            DateTime? date = dateTimePickerStatistics.Value.Date;
            for (int i = EventsList.Count - 1; i >= 0; i--)
            {
                int comparison = EventsList[i].StartTime.Value.Date.CompareTo(date);

                if (comparison == -1)
                {
                    continue;
                }
                if (comparison == 0)
                {
                    startCount7days(i, date);
                    break;
                }
                else
                {
                    dateOver(i, date);
                    break;
                }


            }
        }







        private void buttonGoStatistics_Click(object sender, EventArgs e)
        {
            initChart();
            Height = 400;
            Width = 900;

        }
    }
}
