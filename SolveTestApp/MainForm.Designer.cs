namespace SolveTestApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbEta = new System.Windows.Forms.Label();
            this.TbEta = new System.Windows.Forms.TextBox();
            this.TbLabmda1 = new System.Windows.Forms.TextBox();
            this.LbLambda1 = new System.Windows.Forms.Label();
            this.TbLambda2 = new System.Windows.Forms.TextBox();
            this.LbLambda2 = new System.Windows.Forms.Label();
            this.TbXi = new System.Windows.Forms.TextBox();
            this.LbXi = new System.Windows.Forms.Label();
            this.TbStep = new System.Windows.Forms.TextBox();
            this.LbStep = new System.Windows.Forms.Label();
            this.BtEvaluate = new System.Windows.Forms.Button();
            this.dgvDerivative = new System.Windows.Forms.DataGridView();
            this.ColZDerivative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbH = new System.Windows.Forms.TextBox();
            this.LbH = new System.Windows.Forms.Label();
            this.BtCreateDerivativeChart = new System.Windows.Forms.Button();
            this.CbLambdaCondition = new System.Windows.Forms.CheckBox();
            this.BtCreateFunctionChart = new System.Windows.Forms.Button();
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.BtSave = new System.Windows.Forms.Button();
            this.TbK = new System.Windows.Forms.TextBox();
            this.LbK = new System.Windows.Forms.Label();
            this.TCData = new System.Windows.Forms.TabControl();
            this.tpDerivative = new System.Windows.Forms.TabPage();
            this.TpFunction = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ColZFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColW1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColW2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColW3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.Panel2.SuspendLayout();
            this.SCMain.SuspendLayout();
            this.TCData.SuspendLayout();
            this.tpDerivative.SuspendLayout();
            this.TpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEta
            // 
            this.lbEta.AutoSize = true;
            this.lbEta.Location = new System.Drawing.Point(13, 9);
            this.lbEta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEta.Name = "lbEta";
            this.lbEta.Size = new System.Drawing.Size(88, 17);
            this.lbEta.TabIndex = 0;
            this.lbEta.Text = "Вязкость, η ";
            // 
            // TbEta
            // 
            this.TbEta.Location = new System.Drawing.Point(16, 30);
            this.TbEta.Margin = new System.Windows.Forms.Padding(4);
            this.TbEta.Name = "TbEta";
            this.TbEta.Size = new System.Drawing.Size(247, 22);
            this.TbEta.TabIndex = 1;
            this.TbEta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // TbLabmda1
            // 
            this.TbLabmda1.Location = new System.Drawing.Point(16, 77);
            this.TbLabmda1.Margin = new System.Windows.Forms.Padding(4);
            this.TbLabmda1.Name = "TbLabmda1";
            this.TbLabmda1.Size = new System.Drawing.Size(247, 22);
            this.TbLabmda1.TabIndex = 3;
            this.TbLabmda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbLambda1
            // 
            this.LbLambda1.AutoSize = true;
            this.LbLambda1.Location = new System.Drawing.Point(13, 56);
            this.LbLambda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLambda1.Name = "LbLambda1";
            this.LbLambda1.Size = new System.Drawing.Size(206, 17);
            this.LbLambda1.TabIndex = 2;
            this.LbLambda1.Text = "Коэффициент релаксации, λ1";
            // 
            // TbLambda2
            // 
            this.TbLambda2.Location = new System.Drawing.Point(16, 124);
            this.TbLambda2.Margin = new System.Windows.Forms.Padding(4);
            this.TbLambda2.Name = "TbLambda2";
            this.TbLambda2.Size = new System.Drawing.Size(247, 22);
            this.TbLambda2.TabIndex = 5;
            this.TbLambda2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbLambda2
            // 
            this.LbLambda2.AutoSize = true;
            this.LbLambda2.Location = new System.Drawing.Point(13, 103);
            this.LbLambda2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLambda2.Name = "LbLambda2";
            this.LbLambda2.Size = new System.Drawing.Size(210, 17);
            this.LbLambda2.TabIndex = 4;
            this.LbLambda2.Text = "Коэффициент релаксации, λ2 ";
            // 
            // TbXi
            // 
            this.TbXi.Location = new System.Drawing.Point(16, 171);
            this.TbXi.Margin = new System.Windows.Forms.Padding(4);
            this.TbXi.Name = "TbXi";
            this.TbXi.Size = new System.Drawing.Size(247, 22);
            this.TbXi.TabIndex = 7;
            this.TbXi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbXi
            // 
            this.LbXi.AutoSize = true;
            this.LbXi.Location = new System.Drawing.Point(13, 150);
            this.LbXi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbXi.Name = "LbXi";
            this.LbXi.Size = new System.Drawing.Size(152, 17);
            this.LbXi.TabIndex = 6;
            this.LbXi.Text = "Перепад давления, ξ ";
            // 
            // TbStep
            // 
            this.TbStep.Location = new System.Drawing.Point(16, 312);
            this.TbStep.Margin = new System.Windows.Forms.Padding(4);
            this.TbStep.Name = "TbStep";
            this.TbStep.Size = new System.Drawing.Size(247, 22);
            this.TbStep.TabIndex = 13;
            this.TbStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbStep
            // 
            this.LbStep.AutoSize = true;
            this.LbStep.Location = new System.Drawing.Point(13, 291);
            this.LbStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbStep.Name = "LbStep";
            this.LbStep.Size = new System.Drawing.Size(32, 17);
            this.LbStep.TabIndex = 12;
            this.LbStep.Text = "Шаг";
            // 
            // BtEvaluate
            // 
            this.BtEvaluate.Location = new System.Drawing.Point(13, 374);
            this.BtEvaluate.Margin = new System.Windows.Forms.Padding(4);
            this.BtEvaluate.Name = "BtEvaluate";
            this.BtEvaluate.Size = new System.Drawing.Size(247, 28);
            this.BtEvaluate.TabIndex = 15;
            this.BtEvaluate.Text = "Вычислить";
            this.BtEvaluate.UseVisualStyleBackColor = true;
            this.BtEvaluate.Click += new System.EventHandler(this.BtEvaluate_Click);
            // 
            // dgvDerivative
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDerivative.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDerivative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDerivative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColZDerivative,
            this.ColA1,
            this.ColA2,
            this.ColA3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDerivative.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDerivative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDerivative.Location = new System.Drawing.Point(4, 4);
            this.dgvDerivative.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDerivative.Name = "dgvDerivative";
            this.dgvDerivative.RowHeadersVisible = false;
            this.dgvDerivative.Size = new System.Drawing.Size(718, 545);
            this.dgvDerivative.TabIndex = 16;
            // 
            // ColZDerivative
            // 
            this.ColZDerivative.HeaderText = "z";
            this.ColZDerivative.Name = "ColZDerivative";
            this.ColZDerivative.Width = 120;
            // 
            // ColA1
            // 
            this.ColA1.HeaderText = "w\'₁";
            this.ColA1.Name = "ColA1";
            this.ColA1.Width = 120;
            // 
            // ColA2
            // 
            this.ColA2.HeaderText = "w\'₂";
            this.ColA2.Name = "ColA2";
            this.ColA2.Width = 120;
            // 
            // ColA3
            // 
            this.ColA3.HeaderText = "w\'₃";
            this.ColA3.Name = "ColA3";
            this.ColA3.Width = 120;
            // 
            // TbH
            // 
            this.TbH.Location = new System.Drawing.Point(16, 218);
            this.TbH.Margin = new System.Windows.Forms.Padding(4);
            this.TbH.Name = "TbH";
            this.TbH.Size = new System.Drawing.Size(247, 22);
            this.TbH.TabIndex = 9;
            this.TbH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbH
            // 
            this.LbH.AutoSize = true;
            this.LbH.Location = new System.Drawing.Point(13, 197);
            this.LbH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbH.Name = "LbH";
            this.LbH.Size = new System.Drawing.Size(151, 17);
            this.LbH.TabIndex = 8;
            this.LbH.Text = "Толщина канала, h = ";
            // 
            // BtCreateDerivativeChart
            // 
            this.BtCreateDerivativeChart.Enabled = false;
            this.BtCreateDerivativeChart.Location = new System.Drawing.Point(13, 446);
            this.BtCreateDerivativeChart.Margin = new System.Windows.Forms.Padding(4);
            this.BtCreateDerivativeChart.Name = "BtCreateDerivativeChart";
            this.BtCreateDerivativeChart.Size = new System.Drawing.Size(247, 33);
            this.BtCreateDerivativeChart.TabIndex = 16;
            this.BtCreateDerivativeChart.Text = "График производной";
            this.BtCreateDerivativeChart.UseVisualStyleBackColor = true;
            this.BtCreateDerivativeChart.Click += new System.EventHandler(this.BtCreateChart_Click);
            // 
            // CbLambdaCondition
            // 
            this.CbLambdaCondition.AutoSize = true;
            this.CbLambdaCondition.Checked = true;
            this.CbLambdaCondition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLambdaCondition.Location = new System.Drawing.Point(14, 345);
            this.CbLambdaCondition.Margin = new System.Windows.Forms.Padding(4);
            this.CbLambdaCondition.Name = "CbLambdaCondition";
            this.CbLambdaCondition.Size = new System.Drawing.Size(157, 21);
            this.CbLambdaCondition.TabIndex = 14;
            this.CbLambdaCondition.Text = "Проверка 3*λ2 ≥ λ1";
            this.CbLambdaCondition.UseVisualStyleBackColor = true;
            // 
            // BtCreateFunctionChart
            // 
            this.BtCreateFunctionChart.Enabled = false;
            this.BtCreateFunctionChart.Location = new System.Drawing.Point(14, 487);
            this.BtCreateFunctionChart.Margin = new System.Windows.Forms.Padding(4);
            this.BtCreateFunctionChart.Name = "BtCreateFunctionChart";
            this.BtCreateFunctionChart.Size = new System.Drawing.Size(247, 33);
            this.BtCreateFunctionChart.TabIndex = 17;
            this.BtCreateFunctionChart.Text = "График функции";
            this.BtCreateFunctionChart.UseVisualStyleBackColor = true;
            this.BtCreateFunctionChart.Click += new System.EventHandler(this.BtCreateFunctionChart_Click);
            // 
            // SCMain
            // 
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SCMain.Location = new System.Drawing.Point(0, 0);
            this.SCMain.Margin = new System.Windows.Forms.Padding(4);
            this.SCMain.Name = "SCMain";
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.BtClear);
            this.SCMain.Panel1.Controls.Add(this.BtSave);
            this.SCMain.Panel1.Controls.Add(this.TbK);
            this.SCMain.Panel1.Controls.Add(this.LbK);
            this.SCMain.Panel1.Controls.Add(this.lbEta);
            this.SCMain.Panel1.Controls.Add(this.BtCreateFunctionChart);
            this.SCMain.Panel1.Controls.Add(this.TbEta);
            this.SCMain.Panel1.Controls.Add(this.CbLambdaCondition);
            this.SCMain.Panel1.Controls.Add(this.LbLambda1);
            this.SCMain.Panel1.Controls.Add(this.BtCreateDerivativeChart);
            this.SCMain.Panel1.Controls.Add(this.TbLabmda1);
            this.SCMain.Panel1.Controls.Add(this.TbH);
            this.SCMain.Panel1.Controls.Add(this.LbLambda2);
            this.SCMain.Panel1.Controls.Add(this.LbH);
            this.SCMain.Panel1.Controls.Add(this.TbLambda2);
            this.SCMain.Panel1.Controls.Add(this.LbXi);
            this.SCMain.Panel1.Controls.Add(this.BtEvaluate);
            this.SCMain.Panel1.Controls.Add(this.TbXi);
            this.SCMain.Panel1.Controls.Add(this.TbStep);
            this.SCMain.Panel1.Controls.Add(this.LbStep);
            // 
            // SCMain.Panel2
            // 
            this.SCMain.Panel2.Controls.Add(this.TCData);
            this.SCMain.Size = new System.Drawing.Size(1019, 582);
            this.SCMain.SplitterDistance = 280;
            this.SCMain.SplitterWidth = 5;
            this.SCMain.TabIndex = 17;
            // 
            // BtSave
            // 
            this.BtSave.Enabled = false;
            this.BtSave.Location = new System.Drawing.Point(13, 528);
            this.BtSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(247, 33);
            this.BtSave.TabIndex = 18;
            this.BtSave.Text = "Сохранить в файл";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // TbK
            // 
            this.TbK.Location = new System.Drawing.Point(16, 265);
            this.TbK.Margin = new System.Windows.Forms.Padding(4);
            this.TbK.Name = "TbK";
            this.TbK.Size = new System.Drawing.Size(247, 22);
            this.TbK.TabIndex = 11;
            this.TbK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPress);
            // 
            // LbK
            // 
            this.LbK.AutoSize = true;
            this.LbK.Location = new System.Drawing.Point(13, 244);
            this.LbK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbK.Name = "LbK";
            this.LbK.Size = new System.Drawing.Size(237, 17);
            this.LbK.TabIndex = 10;
            this.LbK.Text = "Коэффициент проскальзывания, k";
            // 
            // TCData
            // 
            this.TCData.Controls.Add(this.tpDerivative);
            this.TCData.Controls.Add(this.TpFunction);
            this.TCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCData.Location = new System.Drawing.Point(0, 0);
            this.TCData.Margin = new System.Windows.Forms.Padding(4);
            this.TCData.Name = "TCData";
            this.TCData.SelectedIndex = 0;
            this.TCData.Size = new System.Drawing.Size(734, 582);
            this.TCData.TabIndex = 18;
            // 
            // tpDerivative
            // 
            this.tpDerivative.Controls.Add(this.dgvDerivative);
            this.tpDerivative.Location = new System.Drawing.Point(4, 25);
            this.tpDerivative.Margin = new System.Windows.Forms.Padding(4);
            this.tpDerivative.Name = "tpDerivative";
            this.tpDerivative.Padding = new System.Windows.Forms.Padding(4);
            this.tpDerivative.Size = new System.Drawing.Size(726, 553);
            this.tpDerivative.TabIndex = 0;
            this.tpDerivative.Text = "Производная";
            this.tpDerivative.UseVisualStyleBackColor = true;
            // 
            // TpFunction
            // 
            this.TpFunction.Controls.Add(this.dgvResults);
            this.TpFunction.Location = new System.Drawing.Point(4, 25);
            this.TpFunction.Margin = new System.Windows.Forms.Padding(4);
            this.TpFunction.Name = "TpFunction";
            this.TpFunction.Padding = new System.Windows.Forms.Padding(4);
            this.TpFunction.Size = new System.Drawing.Size(687, 525);
            this.TpFunction.TabIndex = 1;
            this.TpFunction.Text = "Функция";
            this.TpFunction.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColZFunction,
            this.ColW1,
            this.ColW2,
            this.ColW3});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(4, 4);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(679, 517);
            this.dgvResults.TabIndex = 17;
            // 
            // ColZFunction
            // 
            this.ColZFunction.HeaderText = "z";
            this.ColZFunction.Name = "ColZFunction";
            this.ColZFunction.Width = 120;
            // 
            // ColW1
            // 
            this.ColW1.HeaderText = "w₁";
            this.ColW1.Name = "ColW1";
            this.ColW1.Width = 120;
            // 
            // ColW2
            // 
            this.ColW2.HeaderText = "w₂";
            this.ColW2.Name = "ColW2";
            this.ColW2.Width = 120;
            // 
            // ColW3
            // 
            this.ColW3.HeaderText = "w₃";
            this.ColW3.Name = "ColW3";
            this.ColW3.Width = 120;
            // 
            // BtClear
            // 
            this.BtClear.Location = new System.Drawing.Point(13, 410);
            this.BtClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(247, 28);
            this.BtClear.TabIndex = 19;
            this.BtClear.Text = "Очистить";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 582);
            this.Controls.Add(this.SCMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Решение задачи для модели Олдройда движения вязкоупругих сред";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDerivative)).EndInit();
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel1.PerformLayout();
            this.SCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            this.TCData.ResumeLayout(false);
            this.tpDerivative.ResumeLayout(false);
            this.TpFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEta;
        private System.Windows.Forms.TextBox TbEta;
        private System.Windows.Forms.TextBox TbLabmda1;
        private System.Windows.Forms.Label LbLambda1;
        private System.Windows.Forms.TextBox TbLambda2;
        private System.Windows.Forms.Label LbLambda2;
        private System.Windows.Forms.TextBox TbXi;
        private System.Windows.Forms.Label LbXi;
        private System.Windows.Forms.TextBox TbStep;
        private System.Windows.Forms.Label LbStep;
        private System.Windows.Forms.Button BtEvaluate;
        private System.Windows.Forms.DataGridView dgvDerivative;
        private System.Windows.Forms.TextBox TbH;
        private System.Windows.Forms.Label LbH;
        private System.Windows.Forms.Button BtCreateDerivativeChart;
        private System.Windows.Forms.CheckBox CbLambdaCondition;
        private System.Windows.Forms.Button BtCreateFunctionChart;
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.TabControl TCData;
        private System.Windows.Forms.TabPage tpDerivative;
        private System.Windows.Forms.TabPage TpFunction;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox TbK;
        private System.Windows.Forms.Label LbK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZDerivative;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColZFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColW1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColW2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColW3;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtClear;
    }
}

