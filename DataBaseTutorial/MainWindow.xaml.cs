using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductService productService = new ProductService();
        public List<Product> _myProducts = new List<Product>();

        //private IProductService _productService;

        //protected override void OnStartup (StartupEventArgs e)
        //{

        //}
        public MainWindow()
        {
            InitializeComponent();
            ////BootStrapper.Start();
            ////productService = BootStrapper.Resolve<ProductService>();
            //productService.BussinessLogic(); 
            //_myProducts = productService.GetProductList();
            //ProductList.ItemsSource = _myProducts;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd objproductAdd = new ProductAdd();
            objproductAdd.Show();
            var newProducts = productService.GetProductList().Except(_myProducts);
            _myProducts.AddRange(newProducts);
            ProductList.Items.Refresh();
        }
    }
}
