
namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyDBDataSet = new WindowsFormsApp1.CompanyDBDataSet();
            this.companyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApp1.CompanyDBDataSetTableAdapters.ЗаказыTableAdapter();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new WindowsFormsApp1.CompanyDBDataSetTableAdapters.СотрудникиTableAdapter();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new WindowsFormsApp1.CompanyDBDataSetTableAdapters.КлиентыTableAdapter();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресСчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.адресСчетаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.индексDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // companyDBDataSet
            // 
            this.companyDBDataSet.DataSetName = "CompanyDBDataSet";
            this.companyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyDBDataSetBindingSource
            // 
            this.companyDBDataSetBindingSource.DataSource = this.companyDBDataSet;
            this.companyDBDataSetBindingSource.Position = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.companyDBDataSetBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.companyDBDataSetBindingSource;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.companyDBDataSetBindingSource;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресСчетаDataGridViewTextBoxColumn
            // 
            this.адресСчетаDataGridViewTextBoxColumn.DataPropertyName = "Адрес счета";
            this.адресСчетаDataGridViewTextBoxColumn.HeaderText = "Адрес счета";
            this.адресСчетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресСчетаDataGridViewTextBoxColumn.Name = "адресСчетаDataGridViewTextBoxColumn";
            this.адресСчетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // индексDataGridViewTextBoxColumn
            // 
            this.индексDataGridViewTextBoxColumn.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.индексDataGridViewTextBoxColumn.Name = "индексDataGridViewTextBoxColumn";
            this.индексDataGridViewTextBoxColumn.Width = 125;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource companyDBDataSetBindingSource;
        private CompanyDBDataSet companyDBDataSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private CompanyDBDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private CompanyDBDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private CompanyDBDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресСчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
    }
}

