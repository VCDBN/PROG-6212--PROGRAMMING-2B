namespace LINQExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnTaskCompleted = new Button();
            BtnPending = new Button();
            btnDueDate = new Button();
            btnShowCompleted = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnKeyword = new Button();
            btnAdd = new Button();
            dateTimePickerStartDate = new DateTimePicker();
            BtnFilter = new Button();
            dateTimePickerEndDate = new DateTimePicker();
            btnCountPendingTasks = new Button();
            btnCountCompletedTasks = new Button();
            btnGroupBy = new Button();
            btnTaskStatusProjection = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(454, 229);
            dataGridView1.TabIndex = 0;
            // 
            // btnTaskCompleted
            // 
            btnTaskCompleted.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaskCompleted.Location = new Point(528, 15);
            btnTaskCompleted.Name = "btnTaskCompleted";
            btnTaskCompleted.Size = new Size(190, 38);
            btnTaskCompleted.TabIndex = 1;
            btnTaskCompleted.Text = "Change Task Status";
            btnTaskCompleted.UseVisualStyleBackColor = true;
            btnTaskCompleted.Click += btnTaskCompleted_Click;
            // 
            // BtnPending
            // 
            BtnPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPending.Location = new Point(528, 59);
            BtnPending.Name = "BtnPending";
            BtnPending.Size = new Size(190, 36);
            BtnPending.TabIndex = 2;
            BtnPending.Text = "Pending Tasks";
            BtnPending.UseVisualStyleBackColor = true;
            BtnPending.Click += BtnPending_Click;
            // 
            // btnDueDate
            // 
            btnDueDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDueDate.Location = new Point(528, 263);
            btnDueDate.Name = "btnDueDate";
            btnDueDate.Size = new Size(190, 35);
            btnDueDate.TabIndex = 3;
            btnDueDate.Text = "Sort by Due Date";
            btnDueDate.UseVisualStyleBackColor = true;
            btnDueDate.Click += btnDueDate_Click;
            // 
            // btnShowCompleted
            // 
            btnShowCompleted.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowCompleted.Location = new Point(528, 101);
            btnShowCompleted.Name = "btnShowCompleted";
            btnShowCompleted.Size = new Size(190, 63);
            btnShowCompleted.TabIndex = 4;
            btnShowCompleted.Text = "Show all completed Tasks";
            btnShowCompleted.UseVisualStyleBackColor = true;
            btnShowCompleted.Click += btnShowCompleted_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Show Completed/pending Tasks";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // btnKeyword
            // 
            btnKeyword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeyword.Location = new Point(50, 263);
            btnKeyword.Name = "btnKeyword";
            btnKeyword.Size = new Size(190, 35);
            btnKeyword.TabIndex = 8;
            btnKeyword.Text = "Filter by Keyword";
            btnKeyword.UseVisualStyleBackColor = true;
            btnKeyword.Click += btnKeyword_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(528, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 35);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add New Task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(50, 385);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(200, 23);
            dateTimePickerStartDate.TabIndex = 10;
            // 
            // BtnFilter
            // 
            BtnFilter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFilter.Location = new Point(50, 344);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(190, 35);
            BtnFilter.TabIndex = 11;
            BtnFilter.Text = "Filter Date";
            BtnFilter.UseVisualStyleBackColor = true;
            BtnFilter.Click += BtnFilter_Click;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(269, 385);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(200, 23);
            dateTimePickerEndDate.TabIndex = 12;
            // 
            // btnCountPendingTasks
            // 
            btnCountPendingTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCountPendingTasks.Location = new Point(31, 449);
            btnCountPendingTasks.Name = "btnCountPendingTasks";
            btnCountPendingTasks.Size = new Size(219, 37);
            btnCountPendingTasks.TabIndex = 13;
            btnCountPendingTasks.Text = "Count pending Tasks";
            btnCountPendingTasks.UseVisualStyleBackColor = true;
            btnCountPendingTasks.Click += btnCountPendingTasks_Click;
            // 
            // btnCountCompletedTasks
            // 
            btnCountCompletedTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCountCompletedTasks.Location = new Point(269, 449);
            btnCountCompletedTasks.Name = "btnCountCompletedTasks";
            btnCountCompletedTasks.Size = new Size(235, 37);
            btnCountCompletedTasks.TabIndex = 14;
            btnCountCompletedTasks.Text = "Count Completed Tasks";
            btnCountCompletedTasks.UseVisualStyleBackColor = true;
            btnCountCompletedTasks.Click += btnCountCompletedTasks_Click;
            // 
            // btnGroupBy
            // 
            btnGroupBy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGroupBy.Location = new Point(602, 371);
            btnGroupBy.Name = "btnGroupBy";
            btnGroupBy.Size = new Size(235, 37);
            btnGroupBy.TabIndex = 15;
            btnGroupBy.Text = "Group by Status";
            btnGroupBy.UseVisualStyleBackColor = true;
            btnGroupBy.Click += btnGroupBy_Click;
            // 
            // btnTaskStatusProjection
            // 
            btnTaskStatusProjection.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaskStatusProjection.Location = new Point(602, 449);
            btnTaskStatusProjection.Name = "btnTaskStatusProjection";
            btnTaskStatusProjection.Size = new Size(235, 37);
            btnTaskStatusProjection.TabIndex = 16;
            btnTaskStatusProjection.Text = "Project Task and Status";
            btnTaskStatusProjection.UseVisualStyleBackColor = true;
            btnTaskStatusProjection.Click += btnTaskStatusProjection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 518);
            Controls.Add(btnTaskStatusProjection);
            Controls.Add(btnGroupBy);
            Controls.Add(btnCountCompletedTasks);
            Controls.Add(btnCountPendingTasks);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(BtnFilter);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(btnAdd);
            Controls.Add(btnKeyword);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btnShowCompleted);
            Controls.Add(btnDueDate);
            Controls.Add(BtnPending);
            Controls.Add(btnTaskCompleted);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTaskCompleted;
        private Button BtnPending;
        private Button btnDueDate;
        private Button btnShowCompleted;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnKeyword;
        private Button btnAdd;
        private DateTimePicker dateTimePickerStartDate;
        private Button BtnFilter;
        private DateTimePicker dateTimePickerEndDate;
        private Button btnCountPendingTasks;
        private Button btnCountCompletedTasks;
        private Button btnGroupBy;
        private Button btnTaskStatusProjection;
    }
}