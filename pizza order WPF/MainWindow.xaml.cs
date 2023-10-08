using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace pizza_order
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void Order(object sender, RoutedEventArgs e)
        {
            string selectedPizzaSize = GetSelectedRadioButtonContent(sizeOptions);
            string selectedPaymentMethod = GetSelectedRadioButtonContent(paymentType);
            string selectedBonus = GetSelectedRadioButtonContent(Bonus);

            

            Order orderPizza = new Order();
            orderPizza.SetOrderInfo(selectedPizzaSize, selectedPaymentMethod, selectedBonus);
            orderPizza.Show();
            Close();
        }

        private string GetSelectedRadioButtonContent(ListBox listBox)
        {
            RadioButton selectedRadioButton = listBox.Items.OfType<RadioButton>().FirstOrDefault(rb => rb.IsChecked == true);
            return selectedRadioButton != null ? selectedRadioButton.Content.ToString() : "";
        }




        public MainWindow()
        {
            InitializeComponent();


        }
    }
}
