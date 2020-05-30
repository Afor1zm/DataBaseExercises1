using System;
using DataBaseTutorial.Validators;
using System.Windows;
using FluentValidation;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd 
    {
        public ProductService productService = new ProductService();        
        public ProductAdd()
        {           
            InitializeComponent();            
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            productService.ValidateNewProduct(BoxProductName.Text, BoxProductWeight.Text, ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);
            this.Close();
        }
    }
}
