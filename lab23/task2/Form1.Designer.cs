namespace task2
{
	partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.xminBox = new System.Windows.Forms.TextBox();
			this.xmaxBox = new System.Windows.Forms.TextBox();
			this.stepBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// chart
			// 
			chartArea3.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart.Legends.Add(legend3);
			this.chart.Location = new System.Drawing.Point(30, 25);
			this.chart.Name = "chart";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart.Series.Add(series3);
			this.chart.Size = new System.Drawing.Size(602, 330);
			this.chart.TabIndex = 0;
			this.chart.Text = "chart1";
			// 
			// xminBox
			// 
			this.xminBox.Location = new System.Drawing.Point(69, 399);
			this.xminBox.Name = "xminBox";
			this.xminBox.Size = new System.Drawing.Size(100, 22);
			this.xminBox.TabIndex = 1;
			// 
			// xmaxBox
			// 
			this.xmaxBox.Location = new System.Drawing.Point(210, 399);
			this.xmaxBox.Name = "xmaxBox";
			this.xmaxBox.Size = new System.Drawing.Size(100, 22);
			this.xmaxBox.TabIndex = 2;
			// 
			// stepBox
			// 
			this.stepBox.Location = new System.Drawing.Point(338, 398);
			this.stepBox.Name = "stepBox";
			this.stepBox.Size = new System.Drawing.Size(100, 22);
			this.stepBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 377);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "xMin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(210, 377);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "xMax";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(338, 376);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "шаг";
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(503, 397);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(75, 23);
			this.StartButton.TabIndex = 7;
			this.StartButton.Text = "Расчет!";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 450);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stepBox);
			this.Controls.Add(this.xmaxBox);
			this.Controls.Add(this.xminBox);
			this.Controls.Add(this.chart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.TextBox xminBox;
		private System.Windows.Forms.TextBox xmaxBox;
		private System.Windows.Forms.TextBox stepBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button StartButton;
	}
}

