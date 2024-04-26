using Product.Logic;

namespace Product.UI
{
    
    using ProductClass = Product.Logic.Product;

    public partial class MainForm : Form
    {

        private readonly Reporting _reporting;
        public MainForm()
        {
            IShop<Reporting> shop = new ShopReport();
            //_warehouse = new Warehouse();
            //Interface Segregation Principle
            _reporting = shop.Get();
            InitializeComponent();
        }



        private void btAddProduct_Click(object sender, EventArgs e)
        {
            string[] parts = tbPriceProduct.Text.Split(',');
            Logic.Money money = null;
            if (parts.Length == 2)
            {
                if (int.TryParse(parts[0], out int whole) && int.TryParse(parts[1], out int fraction))
                {
                    //Liskov Substitution
                    money = new Dollar(whole, fraction);
                    //money = new Logic.Money(whole, fraction);
                }
            }
            ProductClass product = new ProductClass(tbNameProduct.Text, money, DateOnly.FromDateTime(dtDate.Value), tbunitOfMeasurement.Text);
            lbRegisterIncoming.Text += $"{_reporting.RegisterIncoming(product)}\n";
            lvProducts.Items.Add(product.ToString());

        }


        private void btBuy_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                foreach (ListViewItem items in lvProducts.SelectedItems)
                {
              
                    string[] pars = items.Text.Split(" ");
                    lbOutReport.Text += _reporting.ShipGoods(pars[0], 1);

                }

            }
        }

        private void tcProduct_Click(object sender, EventArgs e)
        {
            lbSumReport.Text = _reporting.GenerateInventoryReport();

        }
    }
}
