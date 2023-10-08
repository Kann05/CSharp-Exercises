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
using System.Windows.Shapes;

namespace pizza_order
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public void SetOrderInfo(string size, string payment, string bonus)
        {
            sizeTextBlock.Text = $"Selected Pizza Size: {size}";
            paymentTextBlock.Text = $"Selected Payment Method: {payment}";
            bonusTextBlock.Text = $"Selected Bonus: {bonus}";
        }
        public Order()
        {
            InitializeComponent();
        }
    }
}
