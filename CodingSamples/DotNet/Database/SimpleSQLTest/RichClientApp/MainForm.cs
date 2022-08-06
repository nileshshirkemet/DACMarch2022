namespace RichClientApp
{
    public partial class MainForm : Form
    {
        ProductStore store = new ProductStore();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            store.LoadProducts(productBindingSource);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productBindingSource.Current;
            store.UpdateProduct(product);
        }

        private void productBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Product product = (Product)productBindingSource.Current;
            orderBindingSource.Clear();
            store.LoadOrders(product, orderBindingSource);
        }
    }
}