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
    public partial class DerivativeChartForm : Form
    {
        //форма построения графика
        //выбираем первый из целых корней
        public DerivativeChartForm(List<Tuple<double, IEnumerable<double>>> pairs, List<Tuple<double, IEnumerable<double>>> pairsWhenNulls)
        {
            InitializeComponent();

            derivativeChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            derivativeChart.Series[0].Name = "Производная";

            derivativeChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            derivativeChart.Series[1].Name = "При λ1 = λ2 = 0";

            foreach (var pair in pairs)
            {
                derivativeChart.Series[0].Points.AddXY(pair.Item1, pair.Item2.First());
            }

            foreach (var pair in pairsWhenNulls)
            {
                derivativeChart.Series[1].Points.AddXY(pair.Item1, pair.Item2.First());
            }

        }
    }
}
