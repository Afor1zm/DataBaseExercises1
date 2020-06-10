using System.Linq;
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
            RefreshList();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd productAddDialog = new ProductAdd();
            productAddDialog.ShowDialog();
            ProductList.Items.Refresh();
            RefreshList();
        }

        public void RefreshList()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                ProductList.ItemsSource = dbContext.Product.ToList();
            }
        }
    }
}
