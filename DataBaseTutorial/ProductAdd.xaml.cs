using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        private readonly MainWindow _parent;
        public string ProductName { get; set; }

        public ProductAdd(MainWindow parent)
        {
            _parent = parent;
            InitializeComponent();
            
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product(BoxProductName.Text, 01, 0.5, true, "01/02/2020 07:32:17");
            _parent._myProducts.Add(product);            
            _parent.ProductList.Items.Refresh();
            this.Close();
        }
    }
}
