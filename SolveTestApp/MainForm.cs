using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolveTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        List<Tuple<double, IEnumerable<double>>> derivativePairs;
        List<Tuple<double, IEnumerable<double>>> derivativePairsWhenNulls;

        List<Tuple<double, double>> functionPairs;
        List<Tuple<double, double>> functionPairsWhenNulls;

        Microsoft.Office.Interop.Excel.Application app;

        private void BtEvaluate_Click(object sender, EventArgs e)
        {
            dgvDerivative.Rows.Clear();
            dgvResults.Rows.Clear();

            double eta     = Convert.ToDouble(TbEta.Text);
            double lambda1 = Convert.ToDouble(TbLabmda1.Text);
            double lambda2 = Convert.ToDouble(TbLambda2.Text);
            double xi      = Convert.ToDouble(TbXi.Text);
            double h       = Convert.ToDouble(TbH.Text);
            double step    = Convert.ToDouble(TbStep.Text);
            double k       = Convert.ToDouble(TbK.Text);


            if (CbLambdaCondition.Checked && !(3 * lambda2 >= lambda1))
            {
                MessageBox.Show("Условие 3*λ2 ≥ λ1 не выполнено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            derivativePairs = SolveUtils.TableOfRoots(eta, lambda1, lambda2, xi, h, step);
            derivativePairsWhenNulls = SolveUtils.TableOfRoots(eta, 0, 0, xi, h, step);


            BtCreateDerivativeChart.Enabled = true;
            BtCreateFunctionChart.Enabled = true;
            BtSave.Enabled = true;

            int i = 0;

            foreach (var argRootsPair in derivativePairs)
            {
                int j = 1;

                dgvDerivative.Rows.Add();
                dgvDerivative[0, i].Value = string.Format("{0:0.00}", argRootsPair.Item1);

                foreach(var value in argRootsPair.Item2)
                {
                    dgvDerivative[j, i].Value = string.Format("{0:0.00}", value);
                    j++;
                }

                i++;
            }

            functionPairs = SolveUtils.DerivativeToFunction(k, xi, h, derivativePairs);
            functionPairsWhenNulls = SolveUtils.DerivativeToFunction(k, xi, h, derivativePairsWhenNulls);
            
            i = 0;

            foreach (var argRootsPair in functionPairs)
            {
                dgvResults.Rows.Add();
                dgvResults[0, i].Value = string.Format("{0:0.00}", argRootsPair.Item1);
                dgvResults[1, i].Value = string.Format("{0:0.00}", argRootsPair.Item2);
                i++;
            }
        }

        private void BtCreateChart_Click(object sender, EventArgs e)
        {
            DerivativeChartForm derivativeForm = new DerivativeChartForm(derivativePairs, derivativePairsWhenNulls);
            derivativeForm.Show();
        }

        private void BtCreateFunctionChart_Click(object sender, EventArgs e)
        {
            FunctionChartForm functionForm = new FunctionChartForm(functionPairs, functionPairsWhenNulls);
            functionForm.Show();
        }

        private void DoubleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '-') && (sender as TextBox).Text != "")
            {
                e.Handled = true;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if(app == null)
            {
                app = new Microsoft.Office.Interop.Excel.Application();
            }
            var wb = app.Workbooks.Add();

            var wsWDer = wb.Worksheets.Add();
            wsWDer.Name = "w производная";

            wsWDer.Cells[1, 1].Value = "z";
            wsWDer.Cells[1, 2].Value = "w'";

            for (int i = 0; i < dgvDerivative.RowCount; ++i)
            {
                wsWDer.Cells[i + 2, 1] = dgvDerivative.Rows[i].Cells[0].Value;
                wsWDer.Cells[i + 2, 2] = dgvDerivative.Rows[i].Cells[1].Value;
                wsWDer.Cells[i + 2, 3] = dgvDerivative.Rows[i].Cells[2].Value;
            }

            var wsW = wb.Worksheets.Add();
            wsW.Name = "w";

            wsW.Cells[1, 1].Value = "z";
            wsW.Cells[1, 2].Value = "w";

            for (int i = 0; i < dgvDerivative.RowCount; ++i)
            {
                wsW.Cells[i + 2, 1] = dgvResults.Rows[i].Cells[0].Value;
                wsW.Cells[i + 2, 2] = dgvResults.Rows[i].Cells[1].Value;
                wsW.Cells[i + 2, 3] = dgvResults.Rows[i].Cells[2].Value;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FileName = $"Решение задачи η={TbEta.Text} λ1={TbLabmda1.Text} λ2={TbLambda2.Text} 𝜉={TbXi.Text} ℎ={TbH.Text} 𝑘={TbK.Text}"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(sfd.FileName);
                if (file.Exists) file.Delete();

                wb.SaveAs(sfd.FileName);
                wb.Close();

                Close();
            }

        }
    }
}
