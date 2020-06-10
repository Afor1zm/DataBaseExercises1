using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        
        public ProductAdd()
        {           
            InitializeComponent();            
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            var productService = Bootstrapper.Resolve<IProductService>();
            var newProduct = productService.ValidateAndAddNewProduct(BoxProductName.Text, BoxProductWeight.Text, ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);            
            if (newProduct != null)
                Close();            
        }
    }
}
