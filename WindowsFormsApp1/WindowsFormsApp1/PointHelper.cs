using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class PointHelper
    {
        public static void FillChart(Series series)
        {
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 6);
            series.Points.AddXY(4, 25);
            series.Points.AddXY(5, 30);
            series.Points.AddXY(6, 25);
        }
    }
}