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
            btnTaskCompleted.Location = new Point(50, 268);
            btnTaskCompleted.Name = "btnTaskCompleted";
            btnTaskCompleted.Size = new Size(123, 63);
            btnTaskCompleted.TabIndex = 1;
            btnTaskCompleted.Text = "Task Completed";
            btnTaskCompleted.UseVisualStyleBackColor = true;
            btnTaskCompleted.Click += btnTaskCompleted_Click;
            // 
            // BtnPending
            // 
            BtnPending.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPending.Location = new Point(211, 268);
            BtnPending.Name = "BtnPending";
            BtnPending.Size = new Size(123, 63);
            BtnPending.TabIndex = 2;
            BtnPending.Text = "Pending Tasks";
            BtnPending.UseVisualStyleBackColor = true;
            BtnPending.Click += BtnPending_Click;
            // 
            // btnDueDate
            // 
            btnDueDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDueDate.Location = new Point(371, 268);
            btnDueDate.Name = "btnDueDate";
            btnDueDate.Size = new Size(123, 63);
            btnDueDate.TabIndex = 3;
            btnDueDate.Text = "Sort by Due Date";
            btnDueDate.UseVisualStyleBackColor = true;
            btnDueDate.Click += btnDueDate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDueDate);
            Controls.Add(BtnPending);
            Controls.Add(btnTaskCompleted);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTaskCompleted;
        private Button BtnPending;
        private Button btnDueDate;
    }
}