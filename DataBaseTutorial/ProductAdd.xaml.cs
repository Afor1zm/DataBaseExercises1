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
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow._myProducts.Add(new Product(BoxProductName.Text, Convert.ToInt32(BoxProductID.Text), Convert.ToDouble(BoxProductWeight.Text), BoxProductAddled.IsEnabled, "05/02/2019 07:32:17"));
            //MainWindow.ProductList.ItemsSource = MainWindow._myProducts;
        }
    }
}
