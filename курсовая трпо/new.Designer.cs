namespace курсовая_трпо
{
    partial class @new
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnamemasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursedbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet = new курсовая_трпо.courseDataSet();
            this.course_dbTableAdapter = new курсовая_трпо.courseDataSetTableAdapters.course_dbTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursedbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.ordernumDataGridViewTextBoxColumn,
            this.typeofDataGridViewTextBoxColumn,
            this.date1DataGridViewTextBoxColumn,
            this.date2DataGridViewTextBoxColumn,
            this.surnamemasterDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursedbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordernumDataGridViewTextBoxColumn
            // 
            this.ordernumDataGridViewTextBoxColumn.DataPropertyName = "order_num";
            this.ordernumDataGridViewTextBoxColumn.HeaderText = "order_num";
            this.ordernumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordernumDataGridViewTextBoxColumn.Name = "ordernumDataGridViewTextBoxColumn";
            this.ordernumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordernumDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeofDataGridViewTextBoxColumn
            // 
            this.typeofDataGridViewTextBoxColumn.DataPropertyName = "type_of";
            this.typeofDataGridViewTextBoxColumn.HeaderText = "type_of";
            this.typeofDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeofDataGridViewTextBoxColumn.Name = "typeofDataGridViewTextBoxColumn";
            this.typeofDataGridViewTextBoxColumn.Width = 125;
            // 
            // date1DataGridViewTextBoxColumn
            // 
            this.date1DataGridViewTextBoxColumn.DataPropertyName = "date_1";
            this.date1DataGridViewTextBoxColumn.HeaderText = "date_1";
            this.date1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.date1DataGridViewTextBoxColumn.Name = "date1DataGridViewTextBoxColumn";
            this.date1DataGridViewTextBoxColumn.Width = 125;
            // 
            // date2DataGridViewTextBoxColumn
            // 
            this.date2DataGridViewTextBoxColumn.DataPropertyName = "date_2";
            this.date2DataGridViewTextBoxColumn.HeaderText = "date_2";
            this.date2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.date2DataGridViewTextBoxColumn.Name = "date2DataGridViewTextBoxColumn";
            this.date2DataGridViewTextBoxColumn.Width = 125;
            // 
            // surnamemasterDataGridViewTextBoxColumn
            // 
            this.surnamemasterDataGridViewTextBoxColumn.DataPropertyName = "surname_master";
            this.surnamemasterDataGridViewTextBoxColumn.HeaderText = "surname_master";
            this.surnamemasterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnamemasterDataGridViewTextBoxColumn.Name = "surnamemasterDataGridViewTextBoxColumn";
            this.surnamemasterDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursedbBindingSource
            // 
            this.coursedbBindingSource.DataMember = "course_db";
            this.coursedbBindingSource.DataSource = this.courseDataSet;
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "courseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_dbTableAdapter
            // 
            this.course_dbTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Location = new System.Drawing.Point(375, 284);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 36);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(412, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 37);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Введите фамилию мастера";
            // 
            // @new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "@new";
            this.Text = "@new";
            this.Load += new System.EventHandler(this.new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursedbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private courseDataSet courseDataSet;
        private System.Windows.Forms.BindingSource coursedbBindingSource;
        private courseDataSetTableAdapters.course_dbTableAdapter course_dbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamemasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}