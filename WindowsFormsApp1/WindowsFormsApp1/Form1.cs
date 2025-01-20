using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Создаем новый объект Chart
            var chart = new Chart
            {
                Dock = DockStyle.Fill // Задаем размер и расположение
            };

            // Создаем область для графика
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Создаем серию данных
            var series = new Series
            {
                Name = "Series1",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line // Тип графика
            };

            // Добавляем точки данных в серию
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            series.Points.AddXY(4, 25);
            series.Points.AddXY(5, 30);

            // Добавляем серию в график
            chart.Series.Add(series);

            // Добавляем график на форму
            Controls.Add(chart);
            
            Console.WriteLine("Chart created.");
            Console.WriteLine("Hello user."); /* debug line */
        }
    }
}