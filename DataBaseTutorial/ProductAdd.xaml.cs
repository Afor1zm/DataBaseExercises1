using System;
using DataBaseTutorial.Validators;
using System.Windows;
using FluentValidation;
using System;

namespace DataBaseTutorial
{
    /// <summary>
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        private readonly MainWindow _parent;
        public ProductAdd(MainWindow parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void ButtonSaveNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductValidator validator = new ProductValidator();
            {
                try
                {
                    validator.ValidateAndThrow(new Product(BoxProductName.Text, Convert.ToInt32(BoxProductID.Text), Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text), ruleSet: "default");
                    {
                        _parent.AddNewProduct(BoxProductName.Text, Convert.ToInt32(BoxProductID.Text), Convert.ToDouble(BoxProductWeight.Text), ((bool)BoxProductAddled.IsChecked == true), BoxProductDate.Text);
                    }
                    _parent.ProductList.Items.Refresh();
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
