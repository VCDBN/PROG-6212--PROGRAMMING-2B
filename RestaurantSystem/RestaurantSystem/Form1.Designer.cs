namespace RestaurantSystem
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
            lblTableNumber = new Label();
            txtTableNumber = new TextBox();
            txtOrder = new TextBox();
            lblOrder = new Label();
            btnPlaceOrder = new Button();
            lstItems = new ListBox();
            btnProcessOrder = new Button();
            SuspendLayout();
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Location = new Point(42, 33);
            lblTableNumber.Margin = new Padding(5, 0, 5, 0);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(137, 25);
            lblTableNumber.TabIndex = 0;
            lblTableNumber.Text = "Table Number";
            // 
            // txtTableNumber
            // 
            txtTableNumber.Location = new Point(43, 72);
            txtTableNumber.Name = "txtTableNumber";
            txtTableNumber.Size = new Size(100, 33);
            txtTableNumber.TabIndex = 1;
            // 
            // txtOrder
            // 
            txtOrder.Location = new Point(44, 159);
            txtOrder.Name = "txtOrder";
            txtOrder.Size = new Size(195, 33);
            txtOrder.TabIndex = 3;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(43, 120);
            lblOrder.Margin = new Padding(5, 0, 5, 0);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(117, 25);
            lblOrder.TabIndex = 2;
            lblOrder.Text = "Order Items";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(283, 12);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(148, 46);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 25;
            lstItems.Location = new Point(282, 66);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(470, 154);
            lstItems.TabIndex = 5;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Location = new Point(42, 239);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(299, 63);
            btnProcessOrder.TabIndex = 6;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = true;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(796, 313);
            Controls.Add(btnProcessOrder);
            Controls.Add(lstItems);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtOrder);
            Controls.Add(lblOrder);
            Controls.Add(txtTableNumber);
            Controls.Add(lblTableNumber);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTableNumber;
        private TextBox txtTableNumber;
        private TextBox txtOrder;
        private Label lblOrder;
        private Button btnPlaceOrder;
        private ListBox lstItems;
        private Button btnProcessOrder;
    }
}