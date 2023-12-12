using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace shoe_Shop
{
   
    public partial class MainWindow : Window
    {
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                QuantityTextBlock.Text = _quantity.ToString(); 
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {

            Quantity += 1;
        }
    }
}
