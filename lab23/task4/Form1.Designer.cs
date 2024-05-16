namespace task4
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
			this.inputBox = new System.Windows.Forms.TextBox();
			this.xCoordBox = new System.Windows.Forms.TextBox();
			this.yCoordBox = new System.Windows.Forms.TextBox();
			this.createButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(49, 62);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(100, 22);
			this.inputBox.TabIndex = 0;
			// 
			// xCoordBox
			// 
			this.xCoordBox.Location = new System.Drawing.Point(49, 149);
			this.xCoordBox.Name = "xCoordBox";
			this.xCoordBox.Size = new System.Drawing.Size(100, 22);
			this.xCoordBox.TabIndex = 1;
			// 
			// yCoordBox
			// 
			this.yCoordBox.Location = new System.Drawing.Point(49, 188);
			this.yCoordBox.Name = "yCoordBox";
			this.yCoordBox.Size = new System.Drawing.Size(100, 22);
			this.yCoordBox.TabIndex = 2;
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(236, 119);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(95, 23);
			this.createButton.TabIndex = 3;
			this.createButton.Text = "СОЗДАТЬ";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "БУКВА";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "координаты элемента";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.yCoordBox);
			this.Controls.Add(this.xCoordBox);
			this.Controls.Add(this.inputBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.TextBox xCoordBox;
		private System.Windows.Forms.TextBox yCoordBox;
		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

