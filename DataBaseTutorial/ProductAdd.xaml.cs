using System;
using DataBaseTutorial.Validators;
using System.Windows;
using FluentValidation;
using System.Windows.Controls;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd 
    {
        
        public ProductAdd()
        {           
            InitializeComponent();            
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            var container = Bootstrapper.Resolve<IProductService>();            
            container.ValidateNewProduct(BoxProductName.Text, BoxProductWeight.Text, ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);
            this.Close();            
        }
    }
}
