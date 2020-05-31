using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();

            var productService = Bootstrapper.Resolve<IProductService>();

            ProductList.ItemsSource = productService.GetProductList();
            ProductList.Items.Refresh();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd productAddDialog = new ProductAdd();
            productAddDialog.ShowDialog();
            ProductList.Items.Refresh();
        }
    }
}
