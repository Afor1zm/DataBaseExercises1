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
        BusinessLogic businessLogic = new BusinessLogic();        
        public ProductAdd()
        {           
            InitializeComponent();
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductValidator validator = new ProductValidator();
            {
                try
                {
                    validator.ValidateAndThrow(new Product(BoxProductName.Text, businessLogic._myProducts.Count, Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text), ruleSet: "default");
                    {
                        businessLogic.AddNewProduct(BoxProductName.Text, Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);
                    }
                    businessLogic.Refresh();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Use only number for ID and Weighy. Data cn't be less than 1 year before");
                }
            }
        }
    }
}
