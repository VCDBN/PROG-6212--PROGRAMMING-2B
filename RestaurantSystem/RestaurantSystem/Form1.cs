namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string tableNumber = txtTableNumber.Text;
            string orderItems = txtOrder.Text;
            string orderInfo = $"Table {tableNumber}: {orderItems}";

            lstItems.Items.Add(orderInfo);

            txtTableNumber.Clear();
            txtOrder.Clear();
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstItems.SelectedIndex;
            if (selectedIndex >= 0)
            {
                lstItems.Items[selectedIndex] = "[Processed] " + lstItems.Items[selectedIndex];
            }
        }
    }
}