namespace Task1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.databaseTuristDataSet = new Task1.DatabaseTuristDataSet();
			this.туристыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.туристыTableAdapter = new Task1.DatabaseTuristDataSetTableAdapters.ТуристыTableAdapter();
			this.кодТуристаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseTuristDataSet1 = new Task1.DatabaseTuristDataSet1();
			this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.турыTableAdapter = new Task1.DatabaseTuristDataSet1TableAdapters.ТурыTableAdapter();
			this.кодТураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТуристаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.туристыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(26, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 82;
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.Size = new System.Drawing.Size(525, 196);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТураDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.турыBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(26, 273);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 82;
			this.dataGridView2.RowTemplate.Height = 33;
			this.dataGridView2.Size = new System.Drawing.Size(883, 185);
			this.dataGridView2.TabIndex = 1;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(934, 39);
			this.bindingNavigator1.TabIndex = 2;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 36);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(588, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(321, 22);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(588, 102);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(321, 22);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(588, 159);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(321, 22);
			this.textBox3.TabIndex = 5;
			// 
			// databaseTuristDataSet
			// 
			this.databaseTuristDataSet.DataSetName = "DatabaseTuristDataSet";
			this.databaseTuristDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// туристыBindingSource
			// 
			this.туристыBindingSource.DataMember = "Туристы";
			this.туристыBindingSource.DataSource = this.databaseTuristDataSet;
			// 
			// туристыTableAdapter
			// 
			this.туристыTableAdapter.ClearBeforeFill = true;
			// 
			// кодТуристаDataGridViewTextBoxColumn
			// 
			this.кодТуристаDataGridViewTextBoxColumn.DataPropertyName = "Код туриста";
			this.кодТуристаDataGridViewTextBoxColumn.HeaderText = "Код туриста";
			this.кодТуристаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодТуристаDataGridViewTextBoxColumn.Name = "кодТуристаDataGridViewTextBoxColumn";
			this.кодТуристаDataGridViewTextBoxColumn.Width = 125;
			// 
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			this.фамилияDataGridViewTextBoxColumn.Width = 125;
			// 
			// имяDataGridViewTextBoxColumn
			// 
			this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
			this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
			this.имяDataGridViewTextBoxColumn.Width = 125;
			// 
			// отчествоDataGridViewTextBoxColumn
			// 
			this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
			this.отчествоDataGridViewTextBoxColumn.Width = 125;
			// 
			// databaseTuristDataSet1
			// 
			this.databaseTuristDataSet1.DataSetName = "DatabaseTuristDataSet1";
			this.databaseTuristDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// турыBindingSource
			// 
			this.турыBindingSource.DataMember = "Туры";
			this.турыBindingSource.DataSource = this.databaseTuristDataSet1;
			// 
			// турыTableAdapter
			// 
			this.турыTableAdapter.ClearBeforeFill = true;
			// 
			// кодТураDataGridViewTextBoxColumn
			// 
			this.кодТураDataGridViewTextBoxColumn.DataPropertyName = "Код тура";
			this.кодТураDataGridViewTextBoxColumn.HeaderText = "Код тура";
			this.кодТураDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.кодТураDataGridViewTextBoxColumn.Name = "кодТураDataGridViewTextBoxColumn";
			this.кодТураDataGridViewTextBoxColumn.Width = 125;
			// 
			// названиеDataGridViewTextBoxColumn
			// 
			this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
			this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
			this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
			this.названиеDataGridViewTextBoxColumn.Width = 125;
			// 
			// ценаDataGridViewTextBoxColumn
			// 
			this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
			this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
			this.ценаDataGridViewTextBoxColumn.Width = 125;
			// 
			// информацияDataGridViewTextBoxColumn
			// 
			this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
			this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
			this.информацияDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
			this.информацияDataGridViewTextBoxColumn.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(934, 473);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseTuristDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
		private DatabaseTuristDataSet databaseTuristDataSet;
		private System.Windows.Forms.BindingSource туристыBindingSource;
		private DatabaseTuristDataSetTableAdapters.ТуристыTableAdapter туристыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТуристаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private DatabaseTuristDataSet1 databaseTuristDataSet1;
		private System.Windows.Forms.BindingSource турыBindingSource;
		private DatabaseTuristDataSet1TableAdapters.ТурыTableAdapter турыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn кодТураDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
	}
}

