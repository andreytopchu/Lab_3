namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.a1BoundLabel = new System.Windows.Forms.Label();
            this.b1BoundLabel = new System.Windows.Forms.Label();
            this.epsLabel = new System.Windows.Forms.Label();
            this.a1BoundValue = new System.Windows.Forms.TextBox();
            this.b1BoundValue = new System.Windows.Forms.TextBox();
            this.epsValue = new System.Windows.Forms.TextBox();
            this.findRootsButton = new System.Windows.Forms.Button();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.b2BoundValue = new System.Windows.Forms.TextBox();
            this.a2BoundValue = new System.Windows.Forms.TextBox();
            this.b2BoundLabel = new System.Windows.Forms.Label();
            this.a2BoundLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Func2Label = new System.Windows.Forms.Label();
            this.Func1Label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // a1BoundLabel
            // 
            this.a1BoundLabel.AutoSize = true;
            this.a1BoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1BoundLabel.Location = new System.Drawing.Point(19, 90);
            this.a1BoundLabel.Name = "a1BoundLabel";
            this.a1BoundLabel.Size = new System.Drawing.Size(41, 18);
            this.a1BoundLabel.TabIndex = 2;
            this.a1BoundLabel.Text = "a1 = ";
            // 
            // b1BoundLabel
            // 
            this.b1BoundLabel.AutoSize = true;
            this.b1BoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1BoundLabel.Location = new System.Drawing.Point(211, 90);
            this.b1BoundLabel.Name = "b1BoundLabel";
            this.b1BoundLabel.Size = new System.Drawing.Size(41, 18);
            this.b1BoundLabel.TabIndex = 4;
            this.b1BoundLabel.Text = "b1 = ";
            // 
            // epsLabel
            // 
            this.epsLabel.AutoSize = true;
            this.epsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsLabel.Location = new System.Drawing.Point(389, 20);
            this.epsLabel.Name = "epsLabel";
            this.epsLabel.Size = new System.Drawing.Size(49, 18);
            this.epsLabel.TabIndex = 5;
            this.epsLabel.Text = "eps = ";
            // 
            // a1BoundValue
            // 
            this.a1BoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1BoundValue.Location = new System.Drawing.Point(58, 87);
            this.a1BoundValue.Name = "a1BoundValue";
            this.a1BoundValue.Size = new System.Drawing.Size(123, 24);
            this.a1BoundValue.TabIndex = 6;
            this.a1BoundValue.TextChanged += new System.EventHandler(this.a1BoundValue_TextChanged);
            // 
            // b1BoundValue
            // 
            this.b1BoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1BoundValue.Location = new System.Drawing.Point(250, 87);
            this.b1BoundValue.Name = "b1BoundValue";
            this.b1BoundValue.Size = new System.Drawing.Size(123, 24);
            this.b1BoundValue.TabIndex = 7;
            this.b1BoundValue.TextChanged += new System.EventHandler(this.b1BoundValue_TextChanged);
            // 
            // epsValue
            // 
            this.epsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsValue.Location = new System.Drawing.Point(436, 17);
            this.epsValue.Name = "epsValue";
            this.epsValue.Size = new System.Drawing.Size(123, 24);
            this.epsValue.TabIndex = 8;
            this.epsValue.TextChanged += new System.EventHandler(this.epsValue_TextChanged);
            // 
            // findRootsButton
            // 
            this.findRootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findRootsButton.Location = new System.Drawing.Point(98, 12);
            this.findRootsButton.Name = "findRootsButton";
            this.findRootsButton.Size = new System.Drawing.Size(203, 34);
            this.findRootsButton.TabIndex = 9;
            this.findRootsButton.Text = "Вычислить интеграл";
            this.findRootsButton.UseVisualStyleBackColor = true;
            this.findRootsButton.Click += new System.EventHandler(this.findRootsButton_Click);
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildGraphButton.Location = new System.Drawing.Point(659, 12);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(155, 34);
            this.buildGraphButton.TabIndex = 11;
            this.buildGraphButton.Text = "Построить график";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            this.buildGraphButton.Click += new System.EventHandler(this.buildGraphButton_Click);
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Functions";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(398, 59);
            this.graph.Name = "graph";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Functions";
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.Name = "Func1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Functions";
            series2.Name = "Func2";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(591, 431);
            this.graph.TabIndex = 12;
            this.graph.Text = "chart1";
            // 
            // b2BoundValue
            // 
            this.b2BoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2BoundValue.Location = new System.Drawing.Point(250, 163);
            this.b2BoundValue.Name = "b2BoundValue";
            this.b2BoundValue.Size = new System.Drawing.Size(123, 24);
            this.b2BoundValue.TabIndex = 16;
            // 
            // a2BoundValue
            // 
            this.a2BoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2BoundValue.Location = new System.Drawing.Point(58, 163);
            this.a2BoundValue.Name = "a2BoundValue";
            this.a2BoundValue.Size = new System.Drawing.Size(123, 24);
            this.a2BoundValue.TabIndex = 15;
            // 
            // b2BoundLabel
            // 
            this.b2BoundLabel.AutoSize = true;
            this.b2BoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2BoundLabel.Location = new System.Drawing.Point(211, 166);
            this.b2BoundLabel.Name = "b2BoundLabel";
            this.b2BoundLabel.Size = new System.Drawing.Size(41, 18);
            this.b2BoundLabel.TabIndex = 14;
            this.b2BoundLabel.Text = "b2 = ";
            // 
            // a2BoundLabel
            // 
            this.a2BoundLabel.AutoSize = true;
            this.a2BoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2BoundLabel.Location = new System.Drawing.Point(19, 166);
            this.a2BoundLabel.Name = "a2BoundLabel";
            this.a2BoundLabel.Size = new System.Drawing.Size(41, 18);
            this.a2BoundLabel.TabIndex = 13;
            this.a2BoundLabel.Text = "a2 = ";
            // 
            // Func2Label
            // 
            this.Func2Label.AutoSize = true;
            this.Func2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Func2Label.Location = new System.Drawing.Point(93, 126);
            this.Func2Label.Name = "Func2Label";
            this.Func2Label.Size = new System.Drawing.Size(178, 25);
            this.Func2Label.TabIndex = 18;
            this.Func2Label.Text = "cos(x2) + 2x1 = 2";
            // 
            // Func1Label
            // 
            this.Func1Label.AutoSize = true;
            this.Func1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Func1Label.Location = new System.Drawing.Point(93, 59);
            this.Func1Label.Name = "Func1Label";
            this.Func1Label.Size = new System.Drawing.Size(197, 25);
            this.Func1Label.TabIndex = 19;
            this.Func1Label.Text = "cos(x1 + 1) - x2 = 1";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(12, 209);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(380, 281);
            this.dataGridView.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Уточняемый координаты";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Уточненный координаты";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "|| ( f (x(вектор)) ) ||";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 502);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Func1Label);
            this.Controls.Add(this.Func2Label);
            this.Controls.Add(this.b2BoundValue);
            this.Controls.Add(this.a2BoundValue);
            this.Controls.Add(this.b2BoundLabel);
            this.Controls.Add(this.a2BoundLabel);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.findRootsButton);
            this.Controls.Add(this.epsValue);
            this.Controls.Add(this.b1BoundValue);
            this.Controls.Add(this.a1BoundValue);
            this.Controls.Add(this.epsLabel);
            this.Controls.Add(this.b1BoundLabel);
            this.Controls.Add(this.a1BoundLabel);
            this.Name = "Form1";
            this.Text = "Численные методы";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a1BoundLabel;
        private System.Windows.Forms.Label b1BoundLabel;
        private System.Windows.Forms.Label epsLabel;
        private System.Windows.Forms.TextBox a1BoundValue;
        private System.Windows.Forms.TextBox b1BoundValue;
        private System.Windows.Forms.TextBox epsValue;
        private System.Windows.Forms.Button findRootsButton;
        private System.Windows.Forms.DataGridView roots;
        private System.Windows.Forms.Button buildGraphButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.TextBox b2BoundValue;
        private System.Windows.Forms.TextBox a2BoundValue;
        private System.Windows.Forms.Label b2BoundLabel;
        private System.Windows.Forms.Label a2BoundLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Func2Label;
        private System.Windows.Forms.Label Func1Label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

