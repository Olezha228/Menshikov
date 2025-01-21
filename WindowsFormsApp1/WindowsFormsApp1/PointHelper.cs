using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class PointHelper
    {
        public static void FillChart(Chart chart)
        {
            // Определение границ графика
            double xMin = -3.9;
            double xMax = 1.2;
            int segments = 3; // Количество сегментов
            double segmentLength = (xMax - xMin) / segments; // Длина каждого сегмента
            double step = 0.01; // Шаг для построения графика

            // Первая функция: f(x) = x^2 + sin(7*x) - 1
            var series1 = new Series("f(x) = x^2 + sin(7*x) - 1")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Red
            };
            chart.Series.Add(series1);

            // Вторая функция: f(x) = |x^3 + 10^x|
            var series2 = new Series("f(x) = |x^3 + 10^x|")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Green
            };
            chart.Series.Add(series2);

            // Третья функция: f(x) = (2*x^4 + x^2 + 1)^(1/7)
            var series3 = new Series("f(x) = (2*x^4 + x^2 + 1)^(1/7)")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Blue
            };
            chart.Series.Add(series3);

            // Построение графиков по сегментам
            for (int i = 0; i < segments; i++)
            {
                double segmentStart = xMin + i * segmentLength;
                double segmentEnd = segmentStart + segmentLength;

                for (double x = segmentStart; x < segmentEnd; x += step)
                {
                    if (i == 0) // Первая функция
                    {
                        double y1 = Math.Pow(x, 2) + Math.Sin(7 * x) - 1;
                        series1.Points.AddXY(x, y1);
                    }
                    else if (i == 1) // Вторая функция на 2 интервале
                    {
                        double y2 = Math.Abs(Math.Pow(x, 3) + Math.Pow(10, x));
                        series2.Points.AddXY(x, y2);
                    }
                    else if (i == 2) // Третья функция на 3 интервале
                    {
                        double y3 = Math.Pow(2 * Math.Pow(x, 4) + Math.Pow(x, 2) + 1, 1.0 / 7.0);
                        series3.Points.AddXY(x, y3);
                    }
                }
            }
        }
    }
}
