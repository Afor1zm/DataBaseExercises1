using DataBaseTutorial.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using FluentValidation;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using System;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        private readonly MainWindow _parent;
        public ValidationResult results = new ValidationResult();

        public ProductAdd(MainWindow parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductValidator validator = new ProductValidator();
            ValidationResult results = validator.Validate(new Product(BoxProductName.Text, Convert.ToInt32(BoxProductID.Text), Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text));
            if (!results.IsValid)
            {                
                foreach (var failure in results.Errors)
                {
                    MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
            else
            {
                _parent.AddNewProduct(BoxProductName.Text, Convert.ToInt32(BoxProductID.Text), Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);
            }
                                   
            _parent.ProductList.Items.Refresh();
            if (results.IsValid == true)
            {
                this.Close();
            }           
        }
    }
}
