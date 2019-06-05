using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolveTestApp
{
    public partial class FunctionChartForm : Form
    {
        public FunctionChartForm(List<Tuple<double, double>> pairs, List<Tuple<double, double>> pairsWhenNulls)
        {
            InitializeComponent();

            functionChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            functionChart.Series[0].Name = "Функция";

            functionChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            functionChart.Series[1].Name = "При λ1 = λ2 = 0";

            foreach (var pair in pairs)
            {
                functionChart.Series[0].Points.AddXY(pair.Item1, pair.Item2);
            }

            foreach (var pair in pairsWhenNulls)
            {
                functionChart.Series[1].Points.AddXY(pair.Item1, pair.Item2);
            }
        }
    }
}
