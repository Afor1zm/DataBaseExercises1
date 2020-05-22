using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        List<Product> myProducts;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myProducts = new List<Product>();
            myProducts.Add(new Product("Onion", 01, 0.5, true,"01/02/2020 07:32:17"));
            myProducts.Add(new Product("Salat", 02, 1, true, "01/02/2020 07:32:17"));
            myProducts.Add(new Product("Pickle", 03, 2.5, true, "01/02/2020 07:32:17"));
            myProducts.Add(new Product("Potato", 04, 8.56, true, "01/02/2020 07:32:17"));
            myProducts.Add(new Product("Tomato", 05, 0.05, false, "01/02/2020 07:32:17"));

            ProductList.ItemsSource = myProducts;
            
        }
    }
}
